﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GrigorevKU.Sprint6.Task0.V2.Lib
{
    public class DataService : ISprint6Task0V2
    {
        public double Calculate(int x)
        {
            double res = ((2 * x * x - 1) / Math.Sqrt(x * x - 2));
            return Math.Round(res, 3);
        }
    }
}
