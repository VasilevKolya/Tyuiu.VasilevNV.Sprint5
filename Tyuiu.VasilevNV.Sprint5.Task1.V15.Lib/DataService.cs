using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VasilevNV.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public List<string> TabulateFunction(int start, int end, int step)
        {
            var results = new List<string>();
            results.Add("x\t\tF(x)");
            results.Add("---------------------");

            for (int x = start; x <= end; x += step)
            {
                try
                {
                    double denominator = x - 0.4;
                    double value = (Math.Abs(denominator) < 0.0001) ? 0 :
                                 Math.Cos(x) / denominator + Math.Sin(x) * 8 * x + 2;

                    results.Add($"{x}\t\t{Math.Round(value, 2)}");
                }
                catch
                {
                    results.Add($"{x}\t\t0");
                }
            }
            return results;
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            var tabulation = TabulateFunction(startValue, stopValue, 1);
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllLines(filePath, tabulation);
            return filePath;
        }
    }
}