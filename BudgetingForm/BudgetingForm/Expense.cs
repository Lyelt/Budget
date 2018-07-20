using LyeltDatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public class Expense
    {
        public int Id { get;  }

        public string ExpenseName { get; }

        public double Weekly { get; }

        public double Monthly { get; }

        public double Yearly { get; }

        public Expense(int id, string name, double weekly, double monthly, double yearly)
        {
            Id = id;
            ExpenseName = name;
            Weekly = weekly;
            Monthly = monthly;
            Yearly = yearly;
        }

        public static Expense Create(System.Data.SqlClient.SqlDataReader rdr)
        {
            var id = rdr.GetInt("ExpenseId");
            var name = rdr.GetString("ExpenseName");
            var weekly = rdr.GetDouble("Weekly");
            var monthly = rdr.GetDouble("Monthly");
            var yearly = rdr.GetDouble("Yearly");
            return new Expense(id, name, weekly, monthly, yearly);
        }
    }
}
