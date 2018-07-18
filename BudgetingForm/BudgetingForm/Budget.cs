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

        public Budget(int id, string name)
        {
            Name = name ?? throw new ArgumentNullException(name, $"Budget must have a name. Id: {id}");
            Id = id;
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
