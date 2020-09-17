﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Testable
{
    public interface IRandomNumberProvider
    {
        public int Next(int lowerBound, int higherBound);
    }
}
