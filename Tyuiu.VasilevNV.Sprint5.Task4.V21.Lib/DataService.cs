using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.VasilevNV.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();


            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double result = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;


            return Math.Round(result, 3);
        }
    }
}