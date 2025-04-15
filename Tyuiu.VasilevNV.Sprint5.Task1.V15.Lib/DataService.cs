using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VasilevNV.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExits = fileInfo.Exists;
            if (fileExits)
            {
                File.Delete(path);
            }
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                double part1 = Math.Cos(x) / (x - 0.4);
                double part2 = Math.Sin(x) * 8 * x;
                double result = part1 + part2 + 2;
                result = Math.Round(result, 2);
                strY = Convert.ToString(result);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else {
                    File.AppendAllText(path, strY);
                        }
            }
            return path;
            }
        }
    }
