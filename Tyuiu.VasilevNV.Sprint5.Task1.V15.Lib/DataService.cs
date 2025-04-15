using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VasilevNV.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public List<string> TabulateFunction(int start, int end, int step)
        {
            var results = new List<string>();

            for (int x = start; x <= end; x += step)
            {
                double value = CalculateFunctionValue(x);
                results.Add(value.ToString("0.00"));
            }

            return results;
        }

        private double CalculateFunctionValue(int x)
        {
            try
            {
                
                double part1 = Math.Cos(x) / (x - 0.4);
                double part2 = Math.Sin(x) * 8 * x;
                double result = part1 + part2 + 2;

                
                if (double.IsInfinity(result) || double.IsNaN(result))
                    return 0;

                return Math.Round(result, 2);
            }
            catch
            {
                return 0;
            }
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            var tabulation = TabulateFunction(startValue, stopValue, 1);
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

           
            var formattedResults = tabulation.Select(r => r.Replace(",", "."));
            File.WriteAllLines(filePath, formattedResults);

            return filePath;
        }
    }
}