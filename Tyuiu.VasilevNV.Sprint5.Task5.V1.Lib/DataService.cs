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

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;


                string normalizedLine = line.Replace(",", ".").Trim();

                if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (IsEven(number))
                    {
                        sum += number;
                    }
                }
            }

            return Math.Round(sum, 3);
        }

        private bool IsEven(double number)
        {
            return Math.Abs(number % 2) < double.Epsilon;
        }
    }
}