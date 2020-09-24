using System;
using System.Dynamic;

namespace ECS.Testable
{
    public interface ITempSensor
    {
        public int GetTemp();
        public bool RunSelfTest();
    }
}