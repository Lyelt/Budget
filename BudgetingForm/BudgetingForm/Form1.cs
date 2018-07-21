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
            var categories = _budgetHelper.GetExpenseCategories();
            var incomes = _budgetHelper.GetIncome(_currentBudget);

            ListBox_ExpenseCategories.Items.Clear();
            ListBox_ExpenseCategories.Items.AddRange(categories.Select(c => c.CategoryName).ToArray());

            ComboBox_IncomeSources.Items.Clear();
            ComboBox_IncomeSources.Items.AddRange(incomes.Select(i => i.IncomeName).ToArray());
        }

        private void LoadExpenses(string categoryName)
        {
            var expenses = _budgetHelper.GetExpenses(_currentBudget, categoryName);

        }

        private void RadioButton_ManageIncome_CheckedChanged(object sender, EventArgs e)
        {
            Panel_ManageIncome.Visible = RadioButton_ManageIncome.Checked;
        }

        private void RadioButton_ManageExpenses_CheckedChanged(object sender, EventArgs e)
        {
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

        // User clicked an income - show the related data
        private void ComboBox_IncomeSources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // User clicked an expense category - list the proper expenses
        private void ListBox_ExpenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExpenses(ListBox_ExpenseCategories.SelectedItem.ToString());
        }

        // User clicked an expense - show the related data
        private void ListBox_Expenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
