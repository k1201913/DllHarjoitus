﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilteringMethods
{

    // average filter

    internal class AverageFilter : FilterImpl
    {
        internal AverageFilter(int length)
            : base(length)
        {

        }

        public override double Calculate()
        {
            return base.buffer.Average();
        }
    }
}
