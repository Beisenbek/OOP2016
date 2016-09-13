using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Calculator2.Models
{
    public class ConcoleLog:ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
