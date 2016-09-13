using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Models
{
    public class BaseCalculator
    {
        public void WriteResultToFile(string msg)
        {
            StreamWriter sw = new StreamWriter("out.txt",true);
            sw.WriteLine(msg);
            sw.Close();
        }

        public virtual string Add(double a, double b)
        {
            string result = (a + b).ToString();
            WriteResultToFile(result);
            return result;
        }

        public virtual string Minus(double a, double b)
        {
            string result = (a - b).ToString();
            WriteResultToFile(result);
            return result;
        }

    }
}
