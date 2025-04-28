using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {


                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"Файл не найден: {path}", path);
                }

                string content = File.ReadAllText(path, Encoding.UTF8);
                int count = 0;

                for (int i = 0; i < content.Length - 1; i++)
                {
                    if (content[i] == 'т' && content[i + 1] == 'т')
                    {
                        count++;
                    }
                } 

                return count;
            }
        }
    }