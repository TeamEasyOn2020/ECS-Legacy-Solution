using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Testable
{
    public class RandomNumberGenerator : IRandomNumberProvider
    {
        private Random gen = new Random();
        public int Next(int lowerBound, int higherBound)
        {
            return gen.Next(lowerBound, higherBound);
        }       
    }
}
