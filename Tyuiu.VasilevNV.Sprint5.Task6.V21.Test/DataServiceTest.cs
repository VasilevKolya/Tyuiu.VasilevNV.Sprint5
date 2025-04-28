using Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib;
namespace Tyuiu.VasilevNV.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:C:\Users\nvasi\source\repos\Tyuiu.VasilevNV.Sprint5\Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib\bin\Debug\net8.0";
            var res = ds.LoadFromDataFile(path);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckExits()
        {
            DataService ds = new DataService();
            string path = @"C:C:\Users\nvasi\source\repos\Tyuiu.VasilevNV.Sprint5\Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib\bin\Debug\net8.0";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
 