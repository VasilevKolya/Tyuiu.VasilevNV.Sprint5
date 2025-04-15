using Tyuiu.VasilevNV.Sprint5.Task2.V8.Lib;
DataService ds = new DataService();
int[,] mtrx = new int[3, 3] { {9, 4, -6},
                           {3, 9, 9},
                           {-6, 7, -4} }; 
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема:Класс File. Запись структурированных данных в текстовый файл     *");
Console.WriteLine("* Задание #2                                                            *");
Console.WriteLine("* Вариант #8                                                            *");
Console.WriteLine("* Выполнил: Васильев Н. В. | ИСПБ-24-1                                  *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 элементов, заполненный ");
Console.WriteLine("значениями с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0          *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("Массив:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{mtrx[i, j]}\t")
    }
    Console.WriteLine();
}
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
string res = ds.SaveToFileTextData(mtrx);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();

