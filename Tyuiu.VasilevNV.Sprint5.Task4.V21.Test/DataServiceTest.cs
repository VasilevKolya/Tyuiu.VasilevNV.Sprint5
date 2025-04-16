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
            string path = @"C:\Users\nvasi\source\repos\Tyuiu.VasilevNV.Sprint5\Tyuiu.VasilevNV.Sprint5.Task4.V21\bin\Debug\InPutDataFileTask4.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExits = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExits);
        }
    }
}
