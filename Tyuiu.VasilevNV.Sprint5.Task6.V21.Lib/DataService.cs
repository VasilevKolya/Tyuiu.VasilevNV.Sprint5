using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {

            string content = File.ReadAllText(path, Encoding.UTF8);
            int count = 0;

            
            for (int i = 0; i < content.Length - 1; i++)
            {
                char current = content[i];
                char next = content[i + 1];

                if ((current == 'т' || current == 'Т') &&
                    (next == 'т' || next == 'Т'))
                {
                    count++;
                }
            }

            return count;
        }
    }
}