using System;
using System.Dynamic;

namespace ECS.Testable
{
    public class FakeTempSensor : ITempSensor
    {
        public int FakeTemp { get; set; }
        
        
        public int GetTemp()
        {
            return FakeTemp;
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}