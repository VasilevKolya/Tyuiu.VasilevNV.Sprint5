using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System;
using System.Text;
namespace Tyuiu.VasilevNV.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            double res = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
            res = Math.Round(res, 3);

          
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            try
            {
              
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    writer.Write(res);
                }
                return path;
            }
            catch (Exception ex)
            {
            
                return $"Ошибка при сохранении файла: {ex.Message}";
            }
        }
    }
}