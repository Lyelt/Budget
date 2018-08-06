using LyeltDatabaseConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public class Spending
    {
        public int Id { get; }

        public int BudgetId { get; }

        public string CategoryName { get; }

        public string ExpenseName { get; }

        public double Amount { get; }

        public DateTime Date { get; }

        public string Description { get; }

        public Spending(int id, int budgetId, string catName, string expenseName, double amount, DateTime date, string desc)
        {
            Id = id;
            BudgetId = budgetId;
            CategoryName = catName;
            ExpenseName = expenseName;
            Amount = amount;
            Date = date;
            Description = desc;
        }

        public static Spending Create(SqlDataReader rdr)
        {
            var id = rdr.GetInt("Id");
            var budgetId = rdr.GetInt("BudgetId");
            var catName = rdr.GetString("CategoryName");
            var expenseName = rdr.GetString("ExpenseName");
            var amount = rdr.GetDouble("Amount");
            var date = rdr.GetDateTime("Date");
            var desc = rdr.GetString("Description");

            return new Spending(id, budgetId, catName, expenseName, amount, date, desc);
        }
    }
}
