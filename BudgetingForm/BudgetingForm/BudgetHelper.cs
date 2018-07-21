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

            LoadBudgets();
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

        public List<Expense> GetExpenses(Budget b, string categoryName)
        {
            List<Expense> expenses = new List<Expense>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spGetExpensesForBudgetAndCategory", "@budgetId", b.Id, "@expenseCategoryName", categoryName))
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

        public List<Income> GetIncome(Budget b)
        {
            List<Income> incomes = new List<Income>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spGetIncomesForBudget", "@budgetId", b.Id))
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

        public void LoadBudgets()
        {
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
                            _budgets.Add(new Budget(id, name));
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
                    _budgets.Add(new Budget(id, name));
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
    }
}
