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
        private Logger _log;
        private List<Budget> _budgets = new List<Budget>();

        public IReadOnlyList<Budget> Budgets => _budgets.AsReadOnly();

        public BudgetHelper()
        {
            DatabaseHelper.DefaultConnectionString = @"Data Source=NICK-HOME-PC;Initial Catalog=Lyelt;Integrated Security=True";
            LogManager.SetDefaults(new LogOptions(appName: "BudgetForm", verbosity: Enums.LogLevel.Debug));
            _log = LogManager.GetLogger<BudgetHelper>();
            _log.AddLogWriter(new LogFileWriter("BudgetHelperWriter", "logs"));

            ReloadBudgets();
        }

        public List<ExpenseCategory> GetExpenseCategories()
        {
            List<ExpenseCategory> categories = new List<ExpenseCategory>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildTextCommand("SELECT Id, Name FROM ExpenseCategories"))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            var id = rdr.GetInt("Id");
                            var name = rdr.GetString("Name");
                            categories.Add(new ExpenseCategory(id, name));
                            _log.Debug($"Successfully retrieved category [{name}] with ID [{id}]");
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex, "Failed to get category from database");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return categories;
        }

        public List<Expense> GetExpenses(int id, string categoryName = "")
        {
            List<Expense> expenses = new List<Expense>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spGetExpensesForBudgetAndCategory", "@budgetId", id, "@expenseCategoryName", categoryName))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            var newExpense = Expense.Create(rdr);
                            expenses.Add(newExpense);
                            _log.Debug($"Successfully retrieved expense [{newExpense.ExpenseName}] with ID [{newExpense.Id}]");
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex, "Failed to get category from database");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return expenses;
        }

        public List<Income> GetIncome(int id)
        {
            List<Income> incomes = new List<Income>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spGetIncomesForBudget", "@budgetId", id))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        try
                        {
                            var newIncome = Income.Create(rdr);
                            incomes.Add(newIncome);
                            _log.Debug($"Successfully retrieved income [{newIncome.IncomeName}] with ID [{newIncome.Id}]");
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex, "Failed to get category from database");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return incomes;
        }

        public Budget GetBudgetByName(string name)
        {
            Budget budget = null;
            
            try
            {
                budget = _budgets.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
            catch(Exception ex)
            {
                _log.Error(ex);
            }

            return budget;
        }

        public void ReloadBudgets()
        {
            try
            {
                _budgets.Clear();

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
                            var expenses = GetExpenses(id);
                            var income = GetIncome(id);
                            _budgets.Add(new Budget(id, name, expenses, income));
                            _log.Debug($"Successfully retrieved budget [{name}] with ID [{id}]");
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
        }

        public bool TryCreateBudget(string name, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spAddBudget", "@name", name))
                {
                    int id = (int)cmd.ExecuteScalar();
                    _log.Debug($"Successfully added budget [{name}] with ID [{id}] to the database.");
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Error while adding budget {name} to the database: {ex.Message}";
                _log.Error(ex, errorMessage);
                return false;
            }

            return true;
        }

        internal bool TryAddExpense(int id, string categoryName, string expenseName, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spAddExpense", "@budgetId", id, "@categoryName", categoryName, "@expenseName", expenseName))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully added expense [{expenseName}] in category [{categoryName}] to the database.");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while adding expense [{expenseName}] to the database: {ex.Message}";
                _log.Error(ex, error);
                return false;
            }

            return true;
        }

        internal bool TryAddCategory(string categoryName, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spAddCategory","@categoryName", categoryName))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully added category [{categoryName}] to the database.");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while adding expense [{categoryName}] to the database: {ex.Message}";
                _log.Error(ex, error);
                return false;
            }

            return true;
        }

        internal bool TryUpdateExpense(string expenseCategoryName, string expenseName, decimal weekly, decimal monthly, decimal yearly, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spUpdateExpense", "@expenseCategoryName", expenseCategoryName, "@expenseName", expenseName, "@weekly", weekly, "@monthly", monthly, "@yearly", yearly))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully updated expense [{expenseName}] in category [{expenseCategoryName}].");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while updating expense [{expenseName}] in category [{expenseCategoryName}]: {ex.Message}";
                _log.Error(ex, error);
                return false;
            }

            return true;
        }
    }
}
