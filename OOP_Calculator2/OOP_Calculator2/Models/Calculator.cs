using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator2.Models
{
    public class Calculator
    {
        Factory f = new Factory();
        
        public IOperation operation;
        public ILogger log;

        public Calculator(string operation, string logOption)
        {
            this.operation = f.GetOperation(operation);
            this.log = f.GetLogger(logOption);
            this.log.WriteLog(operation);
        }

        public string DoIt(double a, double b)
        {
            return this.operation.DoIt(a, b);
        }

        public void WriteLog(string msg)
        {
            log.WriteLog(msg);
        }

    }
}
