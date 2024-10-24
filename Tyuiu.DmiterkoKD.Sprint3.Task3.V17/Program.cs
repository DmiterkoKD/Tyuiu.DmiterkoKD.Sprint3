using Tyuiu.DmiterkoKD.Sprint3.Task3.V17.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл foreach, которая вычисляет            *");
            Console.WriteLine("* произведение ряда по формуле.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string s = "*vn98n! b,";
            Console.WriteLine("Строка: " + s);
            


            int res = ds.ConvertStringToInt(s);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведения ряда: " + res);
        }
    }
}
