using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Testable
{
    public class FakeRandomNumberGenerator : IRandomNumberProvider
    {
        public int Next(int lowerBound, int higherBound)
        {
            return 23;
        }       
    }
}