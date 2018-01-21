using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BudgetingTool
{
    public static class XmlHelper
    {
        private const string XML_ROOT = "budgets";
        private const string XML_BUDGET = "budget";
        private const string XML_NAME = "name";
        private const string XML_INCOMES = "incomes";
        private const string XML_EXPENSES = "expenses";
        private const string XML_INCOME = "income";
        private const string XML_EXPENSE = "expense";
        private const string XML_ANNUAL = "annual";
        private const string XML_MONTHLY = "monthly";
        private const string XML_WEEKLY = "weekly";
        private const string XML_COLOR = "color";
        private const string XML_EXPENSE_CAT = "expenseCat";

        #region Writer
        /// <summary>
        /// Writes a list of budgets to an xml writer
        /// </summary>
        /// <param name="writer">XmlWriter to write to</param>
        /// <param name="budgets">List of budgets to write</param>
        public static void WriteBudgets(XmlWriter writer, List<Budget> budgets)
        {
            writer.WriteStartDocument();                                // <root>
            writer.WriteStartElement(XML_ROOT);                         // <budgets>

            foreach (Budget budget in budgets)
            {
                WriteBudget(writer, budget);
            }

            writer.WriteEndElement();                                   // </budgets>
            writer.WriteEndDocument();                                  // </root>
        }

        // ---------------------------------------------------------------------------------------
        // Budget
        private static void WriteBudget(XmlWriter writer, Budget budget)
        {
            writer.WriteStartElement(XML_BUDGET);                   // <budget>
            writer.WriteElementString(XML_NAME, budget.Name);       // <name>Nick's Budget</name>

            // -----------------------------------------------------------------------------------
            // Incomes
            writer.WriteStartElement(XML_INCOMES);                  // <incomes>
            foreach (Income income in budget.IncomeSources)
            {
                WriteIncomeOrExpense(writer, income);
            }
            writer.WriteEndElement();                               // </incomes>

            // -----------------------------------------------------------------------------------
            // Expenses
            writer.WriteStartElement(XML_EXPENSES);                 // <expenses>
            foreach (ExpenseCategory cat in budget.ExpenseCategories)
            {
                WriteExpenseCategory(writer, cat);
            }
            writer.WriteEndElement();                               // </expenses>
            writer.WriteEndElement();                               // </budget>
        }

        // ---------------------------------------------------------------------------------------
        // Expense Category
        private static void WriteExpenseCategory(XmlWriter writer, ExpenseCategory cat)
        {
            writer.WriteStartElement(XML_EXPENSE_CAT);          // <expenseCat>
            writer.WriteElementString(XML_NAME, cat.Name);              // <name>Car</name>
            writer.WriteElementString(XML_COLOR, cat.Color.ToString()); // <color>Red</color>
            foreach (Expense expense in cat.Expenses)
            {
                WriteIncomeOrExpense(writer, expense);
            }
            writer.WriteEndElement();                           // </expenseCat>
        }

        // ---------------------------------------------------------------------------------------
        // Income or expense
        private static void WriteIncomeOrExpense(XmlWriter writer, BudgetItem item)
        {
            if (item is Income)
                writer.WriteStartElement(XML_INCOME);
            else
                writer.WriteStartElement(XML_EXPENSE);

            writer.WriteElementString(XML_NAME, item.Name);      // <name>Car Insurance</name>
            writer.WriteElementString(XML_ANNUAL, item.Annual.ToString());  // <annual>1500</annual>
            writer.WriteElementString(XML_MONTHLY, item.Monthly.ToString());// <monthly>150</monthly>
            writer.WriteElementString(XML_WEEKLY, item.Weekly.ToString());  // <weekly>30</weekly>
            writer.WriteEndElement();
        }
        #endregion
        //=====================================================
        //=                                                   =
        //=                                                   =
        //=====================================================
        #region Reader
        public static List<Budget> ReadBudgets(XmlReader reader)
        {
            List<Budget> budgets = new List<Budget>();
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == XML_BUDGET)
                {
                    budgets.Add(ReadBudget(reader));
                }
            }

            return budgets;
        }

        private static Budget ReadBudget(XmlReader reader)
        {
            Budget budget = new Budget();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == XML_BUDGET)
                    break;

                switch(reader.Name)
                {
                    case XML_NAME:
                        budget.Name = reader.Value;
                        break;
                    case XML_EXPENSE_CAT:
                        budget.ExpenseCategories = ReadExpenseCategories(reader);
                        break;
                    case XML_INCOMES:
                        budget.IncomeSources = ReadIncomes(reader);
                        break;
                }
            }
            return budget;
        }

        private static List<ExpenseCategory> ReadExpenseCategories(XmlReader reader)
        {
            List<ExpenseCategory> categories = new List<ExpenseCategory>();
            while (reader.Read())
            {

            }
            return categories;
        }

        private static Expense ReadExpense(XmlReader reader)
        {

        }

        private static List<Income> ReadIncomes(XmlReader reader)
        {

        }

        private static Income ReadIncome(XmlReader reader)
        {

        }
        #endregion
    }
}
