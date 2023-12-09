using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint6.Task6.V22.Lib;
namespace Tyuiu.GrigorevKU.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V22.txt";
            string wait = " MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf ";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V22.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
