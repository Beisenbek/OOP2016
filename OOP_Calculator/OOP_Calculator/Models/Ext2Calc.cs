using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Models
{
    public class Ext2Calc:BaseCalculator
    {
        public override string Add(double a, double b)
        {
            return base.Add(a, b) + "!";
        }
    }
}
