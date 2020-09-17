using System;
using System.Dynamic;

namespace ECS.Testable
{
    public interface ITempSensor
    {
        
        IRandomNumberProvider gen{get; set;}
        public int GetTemp();
        public bool RunSelfTest();
    }
}