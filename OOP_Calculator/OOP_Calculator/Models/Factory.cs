using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Models
{
    public class Factory
    {

        public BaseCalculator GetInstance(string option)
        {
            if (option.Equals("1"))
            {
                return new Models.Ext1Calc();
            }
            else if (option.Equals("2"))
            {
                return new Models.Ext2Calc();
            }

            return new Models.BaseCalculator();
        }
    }
}
