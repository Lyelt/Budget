using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace BudgetingTool
{
    public class BudgetList
    {
        private const string DEFAULT_XML = "Budgets.xml";

        private string _xmlFilePath;
        private List<Budget> _budgets;

        public List<Budget> Budgets
        {
            get
            {
                return _budgets;
            }
            private set
            {
                _budgets = value;
                SaveBudgets();
            }
        }

        /// <summary>
        /// Create a new list of budgets
        /// </summary>
        /// <param name="path">Path of XML file to create from. Creates an empty list by default.</param>
        public BudgetList(string path = "")
        {
            _budgets = new List<Budget>();
            _xmlFilePath = path;
            LoadBudgets();
        }

        public void AddBudget(Budget budget)
        {
            Budgets.Add(budget);
        }

        // Make sure we update the XML file
        // so we can reload the state later
        private void SaveBudgets()
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(GetStream()))
                {
                    XmlHelper.WriteBudgets(writer, Budgets);
                }   
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadBudgets()
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(GetStream()))
                {
                    Budgets = XmlHelper.ReadBudgets(reader);
                }  
            }
            catch (Exception ex)
            {
                
            }
        }

        private FileStream GetStream()
        {
            if (string.IsNullOrEmpty(_xmlFilePath))
                _xmlFilePath = DEFAULT_XML;

            return File.Create(_xmlFilePath);
        }
    }
}
