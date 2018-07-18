using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyeltLogger;
using LyeltDatabaseConnector;

namespace BudgetingForm
{
    public class BudgetHelper
    {
        private static Logger _log;
        static BudgetHelper()
        {
            DatabaseHelper.DefaultConnectionString = @"Data Source=NICK-HOME-PC;Initial Catalog=Lyelt;Integrated Security=True";
            LogManager.SetDefaults(new LogOptions(appName: "BudgetForm", verbosity: Enums.LogLevel.Debug));
            _log = LogManager.GetLogger<BudgetHelper>();
            _log.AddLogWriter(new LogFileWriter("BudgetHelperWriter", "logs"));
        }

        public static List<Budget> GetBudgets()
        {
            List<Budget> budgets = new List<Budget>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildTextCommand("SELECT Id, Name FROM Budgets"))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            var id = rdr.GetInt("Id");
                            var name = rdr.GetString("Name");
                            budgets.Add(new Budget(id, name));
                            _log.Debug($"Successfully retrieved budget with id {id} and name {name}");
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex, "Failed to get budget from database");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return budgets;
        }
    }
}
