using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator2.Models
{
    public class Factory
    {
        public IOperation GetOperation(string operation)
        {
            IOperation result = null;

            switch (operation)
            {
                case "+":
                    result = new Plus();
                    break;
                case "-":
                    result = new Minus();
                    break;
                default:
                    break;
            }

            return result;
        }

       public ILogger GetLogger(string logOption)
        {
            ILogger result = null;

            switch (logOption)
            {
                case "console":
                    result = new ConcoleLog();
                    break;
                case "file":
                    result = new FileLog();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
