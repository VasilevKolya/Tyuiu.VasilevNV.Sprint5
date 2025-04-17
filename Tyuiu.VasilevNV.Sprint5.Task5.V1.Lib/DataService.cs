using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.VasilevNV.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sum = 0;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = "";

            foreach (string line in lines)
            {
               
                if (string.IsNullOrWhiteSpace(line)) continue;

               
                string cleanLine = line.Trim().Replace(",", ".");

                if (double.TryParse(cleanLine, NumberStyles.Any, provider, out double number))
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                }
            }

            return Math.Round(sum, 3);
        }
    }
}