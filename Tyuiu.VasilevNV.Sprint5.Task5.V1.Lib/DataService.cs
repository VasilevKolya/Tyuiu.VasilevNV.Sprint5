using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.VasilevNV.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0.0;

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден!");
                return 0.0;
            }

            string fileContent = File.ReadAllText(path);
            string[] numberStrings = fileContent.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string numStr in numberStrings)
            {
                if (double.TryParse(numStr, out double number))
                {
                    if (number % 2 == 0) 
                    {
                        sum += number;
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка парсинга: '{numStr}'");
                }
            }

            return sum;
        }
    }
}