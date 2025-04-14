using Tyuiu.VasilevNV.Sprint5.Task0.V20.Lib;
using System;
using System.Text;
namespace Tyuiu.VasilevNV.Sprint5.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {

int x = 2;
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                      *");
Console.WriteLine("* Задание #0                                                            *");
Console.WriteLine("* Вариант #20                                                           *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Дано выражение , вычислить его значение при x = 2, результат сохранить   *");
Console.WriteLine("в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой. *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("X = " + x);
DataService ds = new DataService();
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

       string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}