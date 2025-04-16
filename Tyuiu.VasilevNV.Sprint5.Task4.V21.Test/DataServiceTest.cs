using Tyuiu.VasilevNV.Sprint5.Task4.V21.Lib;
using System.IO;
namespace Tyuiu.VasilevNV.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\nvasi\source\repos\Tyuiu.VasilevNV.Sprint5\Tyuiu.VasilevNV.Sprint5.Task4.V21\bin\Debug\InPutDataFileTask4V21.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            double wait = 4.68 * 4.68 + 3 * 4.68 + 5; 
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, res);
        }
    }
}