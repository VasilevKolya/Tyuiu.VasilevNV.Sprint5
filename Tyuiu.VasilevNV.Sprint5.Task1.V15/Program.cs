﻿using System.IO;
using Tyuiu.VasilevNV.Sprint5.Task1.V15.Lib;
DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл              *");
Console.WriteLine("* Задание #0                                                            *");
Console.WriteLine("* Вариант #0                                                            *");
Console.WriteLine("* Выполнил: Васильев Н. В. | ИСПБ-24-1                                  *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая вычисляет выражение 10/ (2 + 3)             *");
Console.WriteLine(" и печатает результат на экране.                                        *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();

