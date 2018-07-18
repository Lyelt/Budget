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
        private List<Budget> _budgets;
        public Form1()
        {
            InitializeComponent();

            _budgets = BudgetHelper.GetBudgets();
            ComboBox_SelectedBudget.Items.AddRange(_budgets.ToArray());
        }
    }
}
