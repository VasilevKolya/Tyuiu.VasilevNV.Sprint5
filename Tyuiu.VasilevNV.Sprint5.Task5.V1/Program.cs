using Tyuiu.VasilevNV.Sprint5.Task5.V1.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                        *");
Console.WriteLine("* Задание #5                                                            *");
Console.WriteLine("* Вариант #1                                                            *");
Console.WriteLine("* Выполнил: Васильев Н. В. | ИСПБ-24-1                                  *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("*Найти сумму всех чисел с признаками деления на 2. Полученный результат   ");
Console.WriteLine(" вывести на консоль. У вещественных значений округлить до трёх знаков после запятой. *");
string path = @"C:\Users\nvasi\source\repos\Tyuiu.VasilevNV.Sprint5\Tyuiu.VasilevNV.Sprint5.Task5.V1\bin\Debug\net8.0\InPutDataFileTask5V1";
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");

Console.WriteLine($"Файл: {path}");
Console.WriteLine("Данные в файле:");
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
double res = ds.LoadFromDataFile(path);

Console.WriteLine($"Сумма четных чисел = {res}");
Console.ReadKey();
    