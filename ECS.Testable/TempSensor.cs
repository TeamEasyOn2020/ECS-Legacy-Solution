using System;
using System.Dynamic;

namespace ECS.Testable
{
    public class TempSensor : ITempSensor
    {
        
        IRandomNumberProvider gen{get; set;}
        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}