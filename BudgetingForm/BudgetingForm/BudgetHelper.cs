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
        #region Static
        private static List<Expense> _allExpenses = new List<Expense>();
        private static List<Income> _allIncomes = new List<Income>();

        public static IReadOnlyList<Expense> AllExpenses => _allExpenses.AsReadOnly();

        public static IReadOnlyList<Income> AllIncomes => _allIncomes.AsReadOnly();
        #endregion

        private Logger _log;
        private List<Budget> _budgets = new List<Budget>();

        public IReadOnlyList<Budget> Budgets => _budgets.AsReadOnly();

        public BudgetHelper()
        {
            DatabaseHelper.DefaultConnectionString = @"Data Source=NICK-HOME-PC;Initial Catalog=Lyelt;Integrated Security=True";
            _log = LogManager.GetLogger<BudgetHelper>(new LogOptions(synchronousLogging: true));
            _log.AddLogWriter(new LogFileWriter("BudgetHelperWriter", @"C:\LyeltLogs"));

            _log.Debug("Budget helper successfully created.");

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
            _log.Debug("Loading budgets");
            try
            {
                _budgets.Clear();
                _allExpenses.Clear();
                _allIncomes.Clear();

                using (var dbc = DatabaseHelper.GetConnector())
                {
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

                    using (var cmd = dbc.BuildTextCommand("SELECT Id as ExpenseId, ExpenseCategoryId, ExpenseName FROM Expenses"))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            try
                            {
                                _allExpenses.Add(Expense.Create(rdr));
                            }
                            catch (Exception ex)
                            {
                                _log.Error(ex, "Failed to get expense from database");
                            }
                        }
                    }

                    using (var cmd = dbc.BuildTextCommand("SELECT Id as IncomeId, Name as IncomeName FROM Income"))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            try
                            {
                                _allIncomes.Add(Income.Create(rdr));
                            }
                            catch (Exception ex)
                            {
                                _log.Error(ex, "Failed to get income from database");
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
            _log.Debug("Budgets loaded.");
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

        internal bool TryUpdateIncome(int budgetId, string incomeName, decimal weekly, decimal monthly, decimal yearly, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spUpdateIncome", "@budgetId", budgetId, "@incomeName", incomeName, "@weekly", weekly, "@monthly", monthly, "@yearly", yearly))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully updated income [{incomeName}].");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while updating income [{incomeName}]: {ex.Message}";
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

        internal bool TryUpdateExpense(int budgetId, string expenseCategoryName, string expenseName, decimal weekly, decimal monthly, decimal yearly, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spUpdateExpense", "@budgetId", budgetId, "@expenseCategoryName", expenseCategoryName, "@expenseName", expenseName, "@weekly", weekly, "@monthly", monthly, "@yearly", yearly))
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

        internal bool TryAddReceipt(int id, string categoryName, string expenseName, decimal amount, DateTime dt, string desc, bool schedule, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spAddReceipt", "@budgetId", id, "@expenseCategoryName", categoryName, "@expenseName", expenseName, "@amount", amount, "@date", dt, "@description", desc, "@schedule", schedule))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully added receipt for [{expenseName}] in category [{categoryName}]. Amount: [{amount}], Date: [{dt}], Description: [{desc}]");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while adding receipt for [{expenseName}] in category [{categoryName}]: {ex.Message}";
                _log.Error(ex, error);
                return false;
            }

            return true;
        }

        internal bool TryAddIncome(int budgetId, string name, out string error)
        {
            error = string.Empty;

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spAddIncome", "@budgetId", budgetId, "@incomeName", name))
                {
                    cmd.ExecuteNonQuery();
                    _log.Debug($"Successfully added income [{name}] to the database.");
                }
            }
            catch (Exception ex)
            {
                error = $"Error while adding income [{name}] to the database: {ex.Message}";
                _log.Error(ex, error);
                return false;
            }

            return true;
        }

        internal List<Spending> GetMonthlySpending(int budgetId, string categoryName, DateTime date)
        {
            List<Spending> spending = new List<Spending>();

            try
            {
                using (var dbc = DatabaseHelper.GetConnector())
                using (var cmd = dbc.BuildStoredProcedureCommand("spGetCurrentMonthlySpending", "@budgetId", budgetId, "@categoryName", categoryName, "@monthNumber", date.Month, "@year", date.Year))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        spending.Add(Spending.Create(rdr));
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }

            return spending;
        }
    }
}
