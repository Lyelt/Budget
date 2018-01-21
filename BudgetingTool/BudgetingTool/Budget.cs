using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingTool
{
    public class Budget
    {
        /// <summary>
        /// Friendly name for the budget
        /// E.g. "Nick Apartment Budget"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of the main categories of expenses
        /// E.g. "Car", "Entertainment", "Shopping"...
        /// </summary>
        public List<ExpenseCategory> ExpenseCategories { get; set; }

        /// <summary>
        /// List of income sources
        /// E.g. "Bernoulli", "CA"
        /// </summary>
        public List<Income> IncomeSources { get; set; }

        /// <summary>
        /// Create an empty budget to be populated later
        /// </summary>
        public Budget()
        {
            ExpenseCategories = new List<ExpenseCategory>();
            IncomeSources = new List<Income>();
            Name = "New Budget";
        }

        /// <summary>
        /// Create a budget from an existing XML file
        /// </summary>
        /// <param name="path">Path to the XML budget file</param>
        public Budget(string path)
        {

        }
    }
}
