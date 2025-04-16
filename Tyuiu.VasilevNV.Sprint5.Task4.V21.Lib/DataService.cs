using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.VasilevNV.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            if (double.TryParse(strX, NumberStyles.Any, CultureInfo.InvariantCulture, out double x)) ;
            double res = Math.Round(Math.Pow(Convert.ToDouble(strX), 2) + 3 * (Convert.ToDouble(strX)) + 5, 3);
            return res;
        }
    }
}
