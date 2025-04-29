using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VasilevNV.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            try
            {
               
                string content = File.ReadAllText(path, Encoding.UTF8);

                
                char[] chars = content.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] >= 'A' && chars[i] <= 'Z')
                    {
                        chars[i] = char.ToLower(chars[i]);
                    }
                }
                string result = new string(chars);

                
                File.WriteAllText(outputPath, result, Encoding.UTF8);

                return outputPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}");
            }
        }
    }
}