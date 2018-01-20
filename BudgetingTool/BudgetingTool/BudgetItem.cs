using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingTool
{
    public class BudgetItem
    {
        private double _annual;
        private double _monthly;
        private double _weekly;

        public string Name { get; set; }

        public double Annual
        {
            get { return _annual; }
            set
            {
                _annual = value;
                _monthly = value / 12;
                _weekly = value / 52;
            }
        }

        public double Monthly
        {
            get { return _monthly; }
            set
            {
                _monthly = value;
                _annual = value * 12;
                _weekly = _annual / 52;
            }
        }

        public double Weekly
        {
            get { return _weekly; }
            set
            {
                _weekly = value;
                _annual = value * 52;
                _monthly = _annual / 12;
            }
        }
    }

    public class Expense : BudgetItem
    {

    }

    public class Income : BudgetItem
    {

    }
}
