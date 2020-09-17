using System;
using System.Dynamic;

namespace ECS.Testable
{
    public class FakeTempSensor : ITempSensor
    {
        
        public IRandomNumberProvider gen{get; set;}
        public FakeTempSensor()
        {
            gen = new FakeRandomNumberGenerator();
        }
        public int GetTemp()
        {
            return gen.Next(0,23);
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}