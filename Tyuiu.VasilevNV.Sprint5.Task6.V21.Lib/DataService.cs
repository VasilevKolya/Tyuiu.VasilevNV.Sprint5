using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
namespace Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {

            string content = File.ReadAllText(path);
            int count = 0;

            for (int i = 0; i < content.Length - 1; i++)
            {
                if (content[i] == 'т' && content[i + 1] == 'т')
                {
                    count++;
                    i++; 
                }
            }

            return count;
        }
    }
}
     