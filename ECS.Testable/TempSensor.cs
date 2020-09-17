using System;
using System.Dynamic;

namespace ECS.Testable
{
    public class TempSensor : ITempSensor
    {
        
        public IRandomNumberProvider gen{get; set;}

        public TempSensor(IRandomNumberProvider rndNumberProvider)
        {
            gen = rndNumberProvider;
        }
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