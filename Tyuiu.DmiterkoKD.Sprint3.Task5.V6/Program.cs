using Tyuiu.DmiterkoKD.Sprint3.Task5.V6.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенный цикл for, которая вычисляет      *");
            Console.WriteLine("* значение функции и суммирует их.                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 10;
            Console.WriteLine("Начальное значение номер 1: " + start1);
            Console.WriteLine("Начальное значение номер 2: " + start2);
            Console.WriteLine("Конечное значение номер 1: " + end1);
            Console.WriteLine("Конечное значение номер 2: " + end2);



            double res = ds.GetSumSumSeries(start1, start2,end1, end2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда: " + res);
        }
    }
}
