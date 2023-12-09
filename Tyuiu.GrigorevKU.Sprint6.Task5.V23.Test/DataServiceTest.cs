using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint6.Task5.V23.Lib;

namespace Tyuiu.GrigorevKU.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\dmitr\source\repos\Tyuiu.GrigorevKU.Sprint6\Tyuiu.GrigorevKU.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { -17, -14.32, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9,
                -1.49, -7 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
