using OOP_Calculator2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            string logOption = Console.ReadLine();
            Calculator c = new Calculator(operation, logOption);
            Console.WriteLine(c.DoIt(2, 3));
        }
    }
}
