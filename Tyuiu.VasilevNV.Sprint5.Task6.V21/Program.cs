using Tyuiu.VasilevNV.Sprint5.Task6.V21.Lib;
DataService ds = new DataService();
Console.WriteLine("*Спринт #5 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #5                                                             *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                      *");
Console.WriteLine("* Задание #6                                                            *");
Console.WriteLine("* Вариант #21                                                           *");
Console.WriteLine("* Выполнил: Васильев Н. В. | ИСПБ-24-1                                  *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("*Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл)      ");
Console.WriteLine("в котором есть набор символьных данных. Найти количество удвоенных букв \"тт\" в заданной строке. *");
string path = $@"{Directory.GetCurrentDirectory()}\InputFileTask6.txt";
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

Console.WriteLine(res);
Console.ReadKey();
