using LyeltDatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public class Income
    {
        public int Id { get; }

        public string IncomeName { get; }

        public double Weekly { get; }

        public double Monthly { get; }

        public double Yearly { get; }

        public Income(int id, string name, double weekly, double monthly, double yearly)
        {
            Id = id;
            IncomeName = name;
            Weekly = weekly;
            Monthly = monthly;
            Yearly = yearly;
        }

        public static Income Create(System.Data.SqlClient.SqlDataReader rdr)
        {
            var id = rdr.GetInt("IncomeId");
            var name = rdr.GetString("IncomeName");
            var weekly = rdr.GetDouble("Weekly");
            var monthly = rdr.GetDouble("Monthly");
            var yearly = rdr.GetDouble("Yearly");
            return new Income(id, name, weekly, monthly, yearly);
        }
    }
}
