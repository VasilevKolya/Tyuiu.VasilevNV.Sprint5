using System.Text;
using Tyuiu.VasilevNV.Sprint5.Task7.V10.Lib;
namespace Tyuiu.VasilevNV.Sprint5.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

           
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Hello WORLD! ABCdef 123 XYZ", Encoding.UTF8);

            string outputPath = ds.LoadDataAndSave(inputPath);

           
            Assert.IsTrue(File.Exists(outputPath));

            
            string result = File.ReadAllText(outputPath);
            Assert.AreEqual("hello world! abcdef 123 xyz", result);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
   