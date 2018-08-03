using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetingForm
{
    public partial class Form1 : Form
    {
        BudgetHelper _budgetHelper;
        Budget _currentBudget;
        List<ExpenseCategory> _expenseCategories;

        public Form1()
        {
            InitializeComponent();
            Scheduler.SetDailyTask();
            this.Numeric_Weekly.TextChanged += new EventHandler(Numeric_Weekly_TextChanged);
            this.Numeric_Monthly.TextChanged += new EventHandler(Numeric_Monthly_TextChanged);
            this.Numeric_Yearly.TextChanged += new EventHandler(Numeric_Yearly_TextChanged);

            _budgetHelper = new BudgetHelper();
            MenuItem_Open.DropDownItems.AddRange(_budgetHelper.Budgets.Select(b => new ToolStripMenuItem(b.Name)).ToArray());
            LoadBudget("Nick's Budget");
        }

        private void LoadBudget(string name, string currentSelectedCategory = null, string currentSelectedExpense = null, string currentSelectedIncome = null)
        {
            Label_CurrentBudgetName.Text = name;
            TabControl_Main.Enabled = true;

            _currentBudget = _budgetHelper.GetBudgetByName(name);
            _expenseCategories = _budgetHelper.GetExpenseCategories();

            ReloadSpendingTable();

            ListBox_Expenses.Items.Clear();

            ListBox_ExpenseCategories.Items.Clear();
            ListBox_ExpenseCategories.Items.AddRange(_expenseCategories.Select(c => c.CategoryName).ToArray());

            ComboBox_IncomeSources.Items.Clear();
            ComboBox_IncomeSources.Items.AddRange(_currentBudget.Incomes.Select(i => i.IncomeName).ToArray());

            ComboBox_IncomeSources.Items.Clear();
            ComboBox_IncomeSources.Items.AddRange(BudgetHelper.AllIncomes.Select(i => i.IncomeName).ToArray());

            ComboBox_SpendingCategory.Items.Clear();
            ComboBox_SpendingCategory.Items.AddRange(_expenseCategories.Select(c => c.CategoryName).ToArray());

            SetDifferenceLabels();

            if (currentSelectedCategory != null)
            {
                ListBox_ExpenseCategories.SelectedIndex = ListBox_ExpenseCategories.Items.IndexOf(currentSelectedCategory);
            }

            if (currentSelectedExpense != null)
            {
                ListBox_Expenses.SelectedIndex = ListBox_Expenses.Items.IndexOf(currentSelectedExpense);
            }

            if (currentSelectedIncome != null)
            {
                ComboBox_IncomeSources.SelectedIndex = ListBox_Expenses.Items.IndexOf(currentSelectedIncome);
            }
        }

        private void SetDifferenceLabels()
        {
            var weeklyExpenses = Math.Round(_currentBudget.Expenses.Sum(e => e.Weekly), 2);
            var monthlyExpenses = Math.Round(_currentBudget.Expenses.Sum(e => e.Monthly), 2);
            var yearlyExpenses = Math.Round(_currentBudget.Expenses.Sum(e => e.Yearly), 2);

            var weeklyIncome = Math.Round(_currentBudget.Incomes.Sum(i => i.Weekly), 2);
            var monthlyIncome = Math.Round(_currentBudget.Incomes.Sum(i => i.Monthly), 2);
            var yearlyIncome = Math.Round(_currentBudget.Incomes.Sum(i => i.Yearly), 2);

            var weeklyDifference = Math.Round(weeklyIncome - weeklyExpenses, 2);
            var monthlyDifference = Math.Round(monthlyIncome - monthlyExpenses, 2);
            var yearlyDifference = Math.Round(yearlyIncome - yearlyExpenses, 2);

            Label_Expenses_W.Text = $"${weeklyExpenses}";
            Label_Expenses_M.Text = $"${monthlyExpenses}";
            Label_Expenses_Y.Text = $"${yearlyExpenses}";
            Label_Income_W.Text = $"${weeklyIncome}";
            Label_Income_M.Text = $"${monthlyIncome}";
            Label_Income_Y.Text = $"${yearlyIncome}";

            Label_Difference_W.Text = $"${weeklyDifference}";
            Label_Difference_M.Text = $"${monthlyDifference}";
            Label_Difference_Y.Text = $"${yearlyDifference}";

            Label_Difference_W.ForeColor = weeklyDifference <= 0 ? Color.Red : Color.Green;
            Label_Difference_M.ForeColor = monthlyDifference <= 0 ? Color.Red : Color.Green;
            Label_Difference_Y.ForeColor = yearlyDifference <= 0 ? Color.Red : Color.Green;
        }

        private void LoadExpenses(int categoryId)
        {
            ListBox_Expenses.Items.Clear();
            ListBox_Expenses.Items.AddRange(_currentBudget.Expenses.Where(e => e.ExpenseCategoryId == categoryId).Select(e => e.ExpenseName).ToArray());
            ComboBox_AddExpense.Items.Clear();
            ComboBox_AddExpense.Items.AddRange(BudgetHelper.AllExpenses.Where(e => e.ExpenseCategoryId == categoryId && !_currentBudget.Expenses.Any(e2 => e2.ExpenseName == e.ExpenseName)).Select(e => e.ExpenseName).ToArray());
        }

        private void LoadAmounts(decimal weekly, decimal monthly, decimal yearly)
        {
            // Hacky way to set the values without triggering the calculation events.
            // We only want to dynamically calculate the values when the user enters a number
            Numeric_Weekly.TextChanged -= Numeric_Weekly_TextChanged;
            Numeric_Monthly.TextChanged -= Numeric_Monthly_TextChanged;
            Numeric_Yearly.TextChanged -= Numeric_Yearly_TextChanged;

            // Actually set the values and validate the range
            Numeric_Weekly.Value = ValidateRange(weekly, Numeric_Weekly);
            Numeric_Monthly.Value = ValidateRange(monthly, Numeric_Monthly);
            Numeric_Yearly.Value = ValidateRange(yearly, Numeric_Yearly);

            // Re-add the event handlers
            Numeric_Weekly.TextChanged += Numeric_Weekly_TextChanged;
            Numeric_Monthly.TextChanged += Numeric_Monthly_TextChanged;
            Numeric_Yearly.TextChanged += Numeric_Yearly_TextChanged;
        }

        private void RadioButton_ManageIncome_CheckedChanged(object sender, EventArgs e)
        {
            LoadAmounts(0, 0, 0);
            Panel_ManageIncome.Visible = RadioButton_ManageIncome.Checked;
        }

        private void RadioButton_ManageExpenses_CheckedChanged(object sender, EventArgs e)
        {
            LoadAmounts(0, 0, 0);
            Panel_ManageExpenses.Visible = RadioButton_ManageExpenses.Checked;
        }

        private void MenuItem_Open_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "New Budget")
                LoadBudget(e.ClickedItem.Text);
        }

        private void TextBox_CreateBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_CreateBudget.ForeColor = SystemColors.InfoText;

            // User pressed enter to save the budget
            if (e.KeyChar == (char)Keys.Return)
            {
                string budgetName = TextBox_CreateBudget.Text;

                if (_budgetHelper.TryCreateBudget(budgetName, out var error))
                {
                    _budgetHelper.ReloadBudgets(); // reload our budget info
                    LoadBudget(budgetName);

                    // Reset the textbox and dropdown items
                    MenuItem_Open.DropDownItems.Add(budgetName);
                    TextBox_CreateBudget.Text = "Budget name...";
                    TextBox_CreateBudget.ForeColor = SystemColors.InactiveCaption;
                }
                else
                {
                    MessageBox.Show(error, "Failed to create budget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_AddIncomeOrExpense_Click(object sender, EventArgs e)
        {
            if (RadioButton_ManageExpenses.Checked)
            {
                if (_budgetHelper.TryUpdateExpense(_currentBudget.Id, ListBox_ExpenseCategories.SelectedItem.ToString(), ListBox_Expenses.SelectedItem.ToString(), Numeric_Weekly.Value, Numeric_Monthly.Value, Numeric_Yearly.Value, out var err))
                {
                    ReloadBudgetInfo();
                    LoadAmounts(0, 0, 0);
                }
                else
                {
                    MessageBox.Show(err, "Failed to update expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_budgetHelper.TryUpdateIncome(_currentBudget.Id, ComboBox_IncomeSources.SelectedItem.ToString(), Numeric_Weekly.Value, Numeric_Monthly.Value, Numeric_Yearly.Value, out var err))
                {
                    ReloadBudgetInfo();
                    LoadAmounts(0, 0, 0);
                }
                else
                {
                    MessageBox.Show(err, "Failed to update income", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // User clicked an expense category - list the proper expenses
        private void ListBox_ExpenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_ExpenseCategories.SelectedItem == null)
                return;

            LoadAmounts(0, 0, 0);
            var id = _expenseCategories.First(ec => ec.CategoryName == ListBox_ExpenseCategories.SelectedItem.ToString()).Id;
            LoadExpenses(id);
            Button_AddIncomeOrExpense.Enabled = false;
        }

        // User clicked an income - show the related data
        private void ComboBox_IncomeSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_IncomeSources.SelectedItem == null)
                return;

            Income selected = _currentBudget.Incomes.FirstOrDefault(i => i.IncomeName == ComboBox_IncomeSources.SelectedItem.ToString());

            if (selected == null)
            {
                AddIncome(ComboBox_IncomeSources.SelectedItem?.ToString() ?? ComboBox_IncomeSources.SelectedText);
                selected = _currentBudget.Incomes.FirstOrDefault(i => i.IncomeName == ComboBox_IncomeSources.SelectedItem.ToString());

                if (selected == null)
                    return;
            }

            LoadAmounts((decimal)selected.Weekly, (decimal)selected.Monthly, (decimal)selected.Yearly);
            Button_AddIncomeOrExpense.Enabled = true;
        }

        // User clicked an expense - show the related data
        private void ListBox_Expenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Expenses.SelectedItem == null)
                return;

            Expense selected = _currentBudget.Expenses.First(exp => exp.ExpenseName == ListBox_Expenses.SelectedItem.ToString());
            LoadAmounts((decimal)selected.Weekly, (decimal)selected.Monthly, (decimal)selected.Yearly);
            Button_AddIncomeOrExpense.Enabled = true;
        }

        private decimal ValidateRange(decimal value, NumericUpDown control)
        {
            return value > control.Maximum ? control.Maximum :
                   value < control.Minimum ? control.Minimum :
                   value;
        }

        private void Numeric_Weekly_TextChanged(object sender, EventArgs e)
        {
            var weekly = decimal.Parse(Numeric_Weekly.Text);
            var yearly = weekly * 52;
            var monthly = yearly / 12;

            LoadAmounts(weekly, monthly, yearly);
        }

        private void Numeric_Monthly_TextChanged(object sender, EventArgs e)
        {
            var monthly = decimal.Parse(Numeric_Monthly.Text);
            var yearly = monthly * 12;
            var weekly = yearly / 52;

            LoadAmounts(weekly, monthly, yearly);
        }

        private void Numeric_Yearly_TextChanged(object sender, EventArgs e)
        {
            var yearly = decimal.Parse(Numeric_Yearly.Text);
            var monthly = yearly / 12;
            var weekly = yearly / 52;

            LoadAmounts(weekly, monthly, yearly);
        }

        private void ComboBox_AddExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox_AddExpense.ForeColor = SystemColors.InfoText;

            // User pressed enter to save the budget
            if (e.KeyChar == (char)Keys.Return)
            {
                AddExpense(ComboBox_AddExpense.Text);
            }
        }

        private void ComboBox_AddExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddExpense(ComboBox_AddExpense.SelectedItem.ToString());
        }

        private void AddExpense(string name)
        {
            string categoryName = ListBox_ExpenseCategories.SelectedItem.ToString();
            int id = _currentBudget.Id;

            if (_budgetHelper.TryAddExpense(id, categoryName, name, out var error))
            {
                ReloadBudgetInfo();
            }
            else
            {
                MessageBox.Show(error, "Failed to add expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddIncome(string name)
        {
            int budgetId = _currentBudget.Id;

            if (_budgetHelper.TryAddIncome(budgetId, name, out var error))
            {
                ReloadBudgetInfo();
            }
            else
            {
                MessageBox.Show(error, "Failed to add income", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox_AddCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox_AddCategory.ForeColor = SystemColors.InfoText;

            // User pressed enter to save the budget
            if (e.KeyChar == (char)Keys.Return)
            {
                AddCategory(ComboBox_AddCategory.Text);
            }
        }

        private void ComboBox_AddCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCategory(ComboBox_AddCategory.SelectedItem.ToString());
        }

        private void AddCategory(string name)
        {
            if (_budgetHelper.TryAddCategory(name, out var error))
            {
                ReloadBudgetInfo();
            }
            else
            {
                MessageBox.Show(error, "Failed to add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadBudgetInfo()
        {
            _budgetHelper.ReloadBudgets();
            LoadBudget(_currentBudget.Name, ListBox_ExpenseCategories.SelectedItem?.ToString(), ListBox_Expenses.SelectedItem?.ToString(), ComboBox_IncomeSources.SelectedItem?.ToString());
            Button_AddIncomeOrExpense.Enabled = false;
            ComboBox_AddExpense.Text = "Add or create new...";
            ComboBox_AddCategory.Text = "Add or create new...";
            ComboBox_IncomeSources.Text = "Select income source...";
        }

        private void ComboBox_SpendingCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_SpendingExpense.Enabled = true;
            Numeric_SpendingAmount.Enabled = true;
            TextBox_SpendingDescription.Enabled = true;
            MonthCalendar_SpendingMonth.Enabled = true;

            ComboBox_SpendingExpense.Items.Clear();
            var catId = _expenseCategories.First(ec => ec.CategoryName == ComboBox_SpendingCategory.SelectedItem.ToString()).Id;
            ComboBox_SpendingExpense.Items.AddRange(_currentBudget.Expenses.Where(ex => ex.ExpenseCategoryId == catId).Select(ex => ex.ExpenseName).ToArray());
        }

        private void ComboBox_SpendingExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button_SpendingSubmit.Enabled = true;
            Button_SetSchedule.Enabled = true;
        }

        private void Button_SpendingSubmit_Click(object sender, EventArgs e)
        {
            AddReceipt(false);
        }

        private void ReloadSpendingInfo()
        {
            ComboBox_SpendingCategory.ResetText();

            ComboBox_SpendingExpense.Enabled = false;
            ComboBox_SpendingExpense.ResetText();

            Numeric_SpendingAmount.Enabled = false;
            Numeric_SpendingAmount.ResetText();

            TextBox_SpendingDescription.Enabled = false;
            TextBox_SpendingDescription.ResetText();

            MonthCalendar_SpendingMonth.Enabled = false;
            
            Button_SpendingSubmit.Enabled = false;
            Button_SetSchedule.Enabled = false;

            ComboBox_SpendingExpense.Items.Clear();
        }

        private void ReloadSpendingTable()
        {
            spendingTableAdapter.Fill(lyeltDataSet.Spending, _currentBudget.Id);
        }

        private void Button_SetSchedule_Click(object sender, EventArgs e)
        {
            AddReceipt(true);
        }

        private void AddReceipt(bool schedule)
        {
            string categoryName = ComboBox_SpendingCategory.SelectedItem.ToString();
            string expenseName = ComboBox_SpendingExpense.SelectedItem.ToString();
            string desc = TextBox_SpendingDescription.Text;
            decimal amount = Numeric_SpendingAmount.Value;
            int id = _currentBudget.Id;
            DateTime dt = MonthCalendar_SpendingMonth.SelectionRange.Start;

            if (_budgetHelper.TryAddReceipt(id, categoryName, expenseName, amount, dt, desc, schedule, out var error))
            {
                ReloadSpendingInfo();
                ReloadSpendingTable();
            }
            else
            {
                MessageBox.Show(error, "Failed to add receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
