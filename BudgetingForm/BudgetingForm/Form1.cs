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
            _budgetHelper = new BudgetHelper();
            
            MenuItem_Open.DropDownItems.AddRange(_budgetHelper.Budgets.Select(b => new ToolStripMenuItem(b.Name)).ToArray());
        }

        private void LoadBudget(string name)
        {
            TabControl_Main.Enabled = true;

            _currentBudget = _budgetHelper.GetBudgetByName(name);
            _expenseCategories = _budgetHelper.GetExpenseCategories();

            ListBox_Expenses.Items.Clear();

            ListBox_ExpenseCategories.Items.Clear();
            ListBox_ExpenseCategories.Items.AddRange(_expenseCategories.Select(c => c.CategoryName).ToArray());

            ComboBox_IncomeSources.Items.Clear();
            ComboBox_IncomeSources.Items.AddRange(_currentBudget.Incomes.Select(i => i.IncomeName).ToArray());

            SetDifferenceLabels();
        }

        private void SetDifferenceLabels()
        {
            var weeklyExpenses = _currentBudget.Expenses.Sum(e => e.Weekly);
            var monthlyExpenses = _currentBudget.Expenses.Sum(e => e.Monthly);
            var yearlyExpenses = _currentBudget.Expenses.Sum(e => e.Yearly);

            var weeklyIncome = _currentBudget.Incomes.Sum(i => i.Weekly);
            var monthlyIncome = _currentBudget.Incomes.Sum(i => i.Monthly);
            var yearlyIncome = _currentBudget.Incomes.Sum(i => i.Yearly);

            var weeklyDifference = weeklyIncome - weeklyExpenses;
            var monthlyDifference = monthlyIncome - monthlyExpenses;
            var yearlyDifference = yearlyIncome - yearlyExpenses;

            Label_Expenses_W.Text = $"${weeklyExpenses}";
            Label_Expenses_M.Text = $"${monthlyExpenses}";
            Label_Expenses_Y.Text = $"${yearlyExpenses}";
            Label_Income_W.Text = $"${weeklyIncome}";
            Label_Income_M.Text = $"${monthlyIncome}";
            Label_Income_Y.Text = $"${yearlyIncome}";
            Label_Difference_W.Text = $"${weeklyDifference}";
            Label_Difference_M.Text = $"${monthlyDifference}";
            Label_Difference_Y.Text = $"${yearlyDifference}";
        }

        private void LoadExpenses(int categoryId)
        {
            ListBox_Expenses.Items.Clear();
            ListBox_Expenses.Items.AddRange(_currentBudget.Expenses.Where(e => e.ExpenseCategoryId == categoryId).Select(e => e.ExpenseName).ToArray());
        }

        private void LoadAmounts(decimal weekly, decimal monthly, decimal yearly)
        {
            Numeric_Weekly.Value = weekly;
            Numeric_Monthly.Value = monthly;
            Numeric_Yearly.Value = yearly;
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

        }

        // User clicked an expense category - list the proper expenses
        private void ListBox_ExpenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAmounts(0, 0, 0);
            var id = _expenseCategories.First(ec => ec.CategoryName == ListBox_ExpenseCategories.SelectedItem.ToString()).Id;
            LoadExpenses(id);
            Button_AddIncomeOrExpense.Enabled = false;
        }

        // User clicked an income - show the related data
        private void ComboBox_IncomeSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            Income selected = _currentBudget.Incomes.First(i => i.IncomeName == ComboBox_IncomeSources.SelectedItem.ToString());
            LoadAmounts((decimal)selected.Weekly, (decimal)selected.Monthly, (decimal)selected.Yearly);
            Button_AddIncomeOrExpense.Enabled = true;
        }

        // User clicked an expense - show the related data
        private void ListBox_Expenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Expense selected = _currentBudget.Expenses.First(exp => exp.ExpenseName == ListBox_Expenses.SelectedItem.ToString());
            LoadAmounts((decimal)selected.Weekly, (decimal)selected.Monthly, (decimal)selected.Yearly);
            Button_AddIncomeOrExpense.Enabled = true;
        }

        // Calculate yearly and monthly based on weekly
        private void Numeric_Weekly_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_Yearly.Value = Numeric_Weekly.Value * 52;
            Numeric_Monthly.Value = Numeric_Yearly.Value / 12;
        }

        // Calculate yearly and weekly based on monthly
        private void Numeric_Monthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_Yearly.Value = Numeric_Monthly.Value * 12;
            Numeric_Weekly.Value = Numeric_Yearly.Value / 52;
        }

        // Calculate weekly and monthly based on yearly
        private void Numeric_Yearly_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_Weekly.Value = Numeric_Yearly.Value / 52;
            Numeric_Monthly.Value = Numeric_Yearly.Value / 12;
        }
    }
}
