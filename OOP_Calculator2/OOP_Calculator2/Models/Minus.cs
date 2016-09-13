using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator2.Models
{
    public class Minus:IOperation
    {
        public string DoIt(double a, double b)
        {
            return (a - b).ToString();
        }
    }
}
