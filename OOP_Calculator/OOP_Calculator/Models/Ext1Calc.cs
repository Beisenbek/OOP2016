using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Models
{
    public class Ext1Calc : BaseCalculator
    {
        public override string Add(double a, double b)
        {
            string result = (a + b).ToString("#0.000");
            WriteResultToFile(result);
            return result;
        }
    }
}
