using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint6.Task7.V15.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V15.csv";
            int[,] wait = new int[,] { {-18, -10, -11, 18, -14, 4, 9, -20,
                    -16, -20 } , {0, -17, -12, 4, -15, -6, -4, -9, -5, 8 } , { -9, 6, -20, -20, -12, -11, -17, -15, 20, -2 } 
                    , {-10, -7, -20, 7, 16, 3, 19, 19, -16, 8} , {-18, -20, 10, -8, -12, 13, 5, 17, 19, 12}, {-17, 17, -13, 6, 
                    19, 1, 5, 10, 0, 12} , {-19, -13, -15, -11, 12, -20, -1, -7, 3, -8}, {20, 15, 11, 3, -10, 13, -17, 3, 12, 3},
                    { 14, -4, 14, 7, -4, -5, -4, 5, -17, 1} , {-16, -18, 16, -2, 13, 13, 9, 15, 2, 19} };
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void File()
        {
            string openedFile = @"C:\DataSprint6\InPutFileTask7V15.csv";
            FileInfo file = new FileInfo(openedFile);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
