using System;
using System.Dynamic;

namespace ECS.Testable
{
    public interface ITempSensor
    {
        public IRandomNumberGenerator {private get; private set;}


        public int GetTemp();
        public bool RunSelfTest();
    }
}