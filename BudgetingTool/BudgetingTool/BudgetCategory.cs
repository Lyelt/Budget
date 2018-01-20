using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BudgetingTool
{
    public class BudgetCategory
    {
        /// <summary>
        /// Category name
        /// E.g. "Car"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color for graphs and stuff
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Actual expenses contained within the category
        /// </summary>
        public List<Expense> Expenses { get; set; }
    }
}
