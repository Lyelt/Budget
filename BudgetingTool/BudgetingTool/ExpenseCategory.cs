using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BudgetingTool
{
    public class ExpenseCategory
    {
        /// <summary>
        /// Category name
        /// E.g. "Car"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color for graphs and stuff
        /// </summary>
        public System.Drawing.Color Color { get; set; }

        /// <summary>
        /// Actual expenses contained within the category
        /// </summary>
        public List<Expense> Expenses { get; set; }
    }
}
