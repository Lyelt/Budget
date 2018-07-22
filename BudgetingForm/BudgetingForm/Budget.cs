using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public class Budget
    {
        public int Id { get; }

        public string Name { get; }

        public IEnumerable<Expense> Expenses { get; }

        public IEnumerable<Income> Incomes { get; }

        public Budget(int id, string name, IEnumerable<Expense> expenses, IEnumerable<Income> incomes)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name), $"Budget must have a name. Id: {id}");
            Expenses = expenses ?? throw new ArgumentNullException(nameof(expenses), $"Budget must have expense specified. Id: {id}");
            Incomes = incomes ?? throw new ArgumentNullException(nameof(incomes), $"Budget must have income specified. Id: {id}");
        }

        public override bool Equals(object obj)
        {
            return obj is Budget b && b.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
