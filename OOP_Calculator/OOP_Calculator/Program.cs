using OOP_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           string option = Console.ReadLine();
           
           Factory factory = new Factory();

           BaseCalculator calc = factory.GetInstance(option);
           Console.WriteLine(calc.Add(2,3));
        }
    }
}
