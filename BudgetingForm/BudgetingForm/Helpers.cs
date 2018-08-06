using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetingForm
{
    public static class Helpers
    {
        public static double PercentDifference(double val1, double val2)
        {
            return Math.Abs((val2 - val1) / val1) * 100;
        }
    }
}
