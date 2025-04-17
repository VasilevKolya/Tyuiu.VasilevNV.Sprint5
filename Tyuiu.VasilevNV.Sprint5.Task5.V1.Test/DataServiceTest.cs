using Tyuiu.VasilevNV.Sprint5.Task5.V1.Lib;
namespace Tyuiu.VasilevNV.Sprint5.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V1.txt");


            File.WriteAllLines(path, new string[] { "2", "4.5", "6", "8.0", "10.2" });

            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            double wait = 16; 
            Assert.AreEqual(wait, res);
        }
    }
}