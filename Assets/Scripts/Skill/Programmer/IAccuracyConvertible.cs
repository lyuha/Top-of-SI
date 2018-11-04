﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    interface IAccuracyConvertible
    {
        double calculateAppliedAccuracy(double accuracy);
    }
}
