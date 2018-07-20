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

        public Form1()
        {
            InitializeComponent();
            _budgetHelper = new BudgetHelper();
            
            MenuItem_Open.DropDownItems.AddRange(_budgetHelper.Budgets.Select(b => new ToolStripMenuItem(b.Name)).ToArray());
        }

        private void LoadBudget(string name)
        {
            TabControl_Main.Enabled = true;

            Budget b = _budgetHelper.GetBudgetByName(name);
            var categories = _budgetHelper.GetExpenseCategories();
            var incomes = _budgetHelper.GetIncome(b);

            ListBox_ExpenseCategories.Items.Clear();
            ListBox_ExpenseCategories.Items.AddRange(categories.Select(c => c.CategoryName).ToArray());

            ComboBox_IncomeSources.Items.Clear();
            ComboBox_IncomeSources.Items.AddRange(incomes.Select(i => i.IncomeName).ToArray());
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
            LoadBudget(e.ClickedItem.Text);
        }

        private void TextBox_CreateBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_CreateBudget.ForeColor = SystemColors.InfoText;

            if (e.KeyChar == (char)Keys.Return)
            {
                string budgetName = TextBox_CreateBudget.Text;

                if (_budgetHelper.TryCreateBudget(budgetName, out var error))
                {
                    LoadBudget(budgetName);
                }
                else
                {
                    MessageBox.Show(error, "Failed to create budget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
