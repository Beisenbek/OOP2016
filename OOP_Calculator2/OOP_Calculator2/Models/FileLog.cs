using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_Calculator2.Models
{
    class FileLog : ILogger
    {
        public void WriteLog(string msg)
        {
            File.WriteAllText("out2.txt", msg);
        }
    }
}
