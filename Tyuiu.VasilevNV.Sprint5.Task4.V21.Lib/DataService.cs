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

            NumberFormatInfo provider = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
                NumberGroupSeparator = ""
            };

            double x = double.Parse(strX, provider);


            return Math.Round(Math.Pow(x, 3) + 2 * x / Math.Cos(x), 3);
        }
    }
}