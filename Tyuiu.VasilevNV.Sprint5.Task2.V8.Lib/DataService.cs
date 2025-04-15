using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VasilevNV.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            StringBuilder csvContent = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                    int value = matrix[i, j] > 0 ? 1 : 0;
                    csvContent.Append(value);

                    if (j < cols - 1)
                        csvContent.Append(";");
                }
                csvContent.AppendLine();
            }
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            File.WriteAllText(filePath, csvContent.ToString());

            return filePath;
        }
    }
}