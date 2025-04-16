using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.VasilevNV.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
            public double LoadFromDataFile(string path)
            {
               
                string strX = File.ReadAllText(path).Trim();

               
                NumberFormatInfo numberFormat = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                    NumberGroupSeparator = ""
                };

               
                double x = double.Parse(strX, numberFormat);

               
                double result = Math.Pow(x, 2) + 3 * x + 5;

               
                return Math.Round(result, 3);
            }
        }
    }