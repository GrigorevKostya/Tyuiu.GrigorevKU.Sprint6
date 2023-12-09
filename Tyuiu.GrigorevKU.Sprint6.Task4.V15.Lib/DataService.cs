using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrigorevKU.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {               
                y = Math.Round(Math.Sin(x) + ((2*(x))/3) - Math.Cos(x)*4*(x) , 2);
                valueArray[count] = y;
                count++;               
            }
            return valueArray;
        }
    }
}
