using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Testable
{
    public class Logger : ILogger
    {
        public void WriteLogLine(string line)
        {
            Console.WriteLine($"{line}");
        }
    }
}
