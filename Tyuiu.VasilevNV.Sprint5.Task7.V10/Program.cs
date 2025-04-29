using Tyuiu.VasilevNV.Sprint5.Task7.V10.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
Console.WriteLine("* Задание #7                                                            *");
Console.WriteLine("* Вариант #10                                                           *");
Console.WriteLine("* Выполнил: Васильев Н. В. | ИСПБ-24-1                                  *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("*Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором ");
Console.WriteLine("есть набор символьных данных.Заменить все заглавные латинские буквы на строчные *");
string path = $@"{Directory.GetCurrentDirectory()}\InputFileTask7.txt";
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");

Console.WriteLine($"Файл: {path}");
Console.WriteLine("Данные в файле:");
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
string res = ds.LoadDataAndSave(path);

Console.WriteLine(res);
Console.ReadKey();
