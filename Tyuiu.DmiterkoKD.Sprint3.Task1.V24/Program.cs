using Tyuiu.DmiterkoKD.Sprint3.Task1.V24.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле.                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int start = 1;
            int end = 12;
            Console.WriteLine("Переменная x: " + x);
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);


            double res = ds.GetSumSeries(x, start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведения ряда: " + res);
        }
    }
}
