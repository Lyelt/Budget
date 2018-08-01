using LyeltDatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyeltLogger;

namespace RecordExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHelper.DefaultConnectionString = @"Data Source=NICK-HOME-PC;Initial Catalog=Lyelt;Integrated Security=True";
            LogManager.SetDefaults(new LogOptions(appName: "RecordExpenses", verbosity: Enums.LogLevel.Debug));
            var _log = LogManager.GetLogger<Program>();
            _log.AddLogWriter(new LogFileWriter("RecordExpensesWriter", "logs"));

            List<ScheduledTask> tasks = new List<ScheduledTask>();
            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildTextCommand("SELECT Id, ExpenseName, ExpenseCategoryName BudgetId, DayOfMonth, Amount, Description, Completed FROM ScheduledExpenses"))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            tasks.Add(ScheduledTask.Create(rdr));
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            try
            {
                int todayDay = DateTime.Today.Day;
                foreach (var task in tasks)
                {
                    // we passed or hit the day we are supposed to do it, and the task hasnt been completed yet
                    if (task.DayOfMonth <= todayDay && task.Completed.HasValue && !task.Completed.Value)
                    {
                        try
                        {
                            using (var dbc = DatabaseHelper.GetConnector())
                            using (var cmd = dbc.BuildStoredProcedureCommand("spAddReceipt", "@budgetId", task.BudgetId, "@expenseCategoryName", task.ExpenseCategoryName, "@expenseName", task.ExpenseName, "@amount", task.Amount, "@date", DateTime.Today, "@description", task.Description, "@schedule", false))
                            {
                                cmd.ExecuteNonQuery();
                                _log.Debug($"Successfully added receipt for scheduled expense: [{task.ExpenseName}] in category [{task.ExpenseCategoryName}]. Amount: [{task.Amount}], Date: [{DateTime.Today}], Description: [{task.Description}]");
                            }

                            using (var dbc = DatabaseHelper.GetConnector())
                            using (var cmd = dbc.BuildTextCommand("UPDATE ScheduledExpenses SET Completed = 1 WHERE Id = @Id", "@Id", task.Id))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex);
                        }
                    }
                }

                // all tasks have been completed for the month
                if (tasks.All(t => t.Completed.HasValue && t.Completed.Value))
                {
                    try
                    {
                        // update completed status to null for all tasks
                        using (var dbc = DatabaseHelper.GetConnector())
                        using (var cmd = dbc.BuildTextCommand("UPDATE ScheduledExpenses SET Completed = NULL"))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                    }
                }

                // all tasks are null completion (meaning we completed the month) but we are starting the next month
                if (tasks.All(t => !t.Completed.HasValue) && tasks.Any(t => todayDay <= t.DayOfMonth))
                {
                    try
                    {
                        // set completed to 0 so that we can start actually executing the tasks
                        using (var dbc = DatabaseHelper.GetConnector())
                        using (var cmd = dbc.BuildTextCommand("UPDATE ScheduledExpenses SET Completed = 0"))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        _log.Error(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }

    class ScheduledTask
    {
        public int Id { get; set; }

        public string ExpenseName { get; set; }

        public string ExpenseCategoryName { get; set; }

        public int BudgetId { get; set; }

        public int DayOfMonth { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public bool? Completed { get; set; }

        public static ScheduledTask Create(System.Data.SqlClient.SqlDataReader reader)
        {
            ScheduledTask t = new ScheduledTask();
            t.Id = reader.GetInt("Id");
            t.ExpenseName = reader.GetString("ExpenseName");
            t.ExpenseCategoryName = reader.GetString("ExpenseCategoryName");
            t.BudgetId = reader.GetInt("BudgetId");
            t.DayOfMonth = reader.GetInt("DayOfMonth");
            t.Amount = reader.GetDecimal("Amount");
            t.Description = reader.GetString("Description");

            if (reader.IsDBNull(reader.GetOrdinal("Completed")))
                t.Completed = null;
            else
                t.Completed = reader.GetBoolean(reader.GetOrdinal("Completed"));

            return t;
        }
    }
}
