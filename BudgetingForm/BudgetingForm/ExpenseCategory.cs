using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public class ExpenseCategory
    {
        public int Id { get; }

        public string CategoryName { get; }

        public ExpenseCategory(int id, string name)
        {
            Id = id;
            CategoryName = name;
        }
    }
}
