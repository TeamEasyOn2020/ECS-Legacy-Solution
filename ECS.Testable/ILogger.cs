using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Testable
{
    public interface ILogger
    {
        public void WriteLogLine(string line);
    }
}
