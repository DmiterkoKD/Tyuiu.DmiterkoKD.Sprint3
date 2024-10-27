using Tyuiu.DmiterkoKD.Sprint3.Task7.V22.Lib;
namespace Tyuiu.DmiterkoKD.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции.           *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int start = -5;
            int end = 5;
            Console.WriteLine("Начальное значение отрезка: " + start);
            Console.WriteLine("Конечное значение отрезка: " + end);
            int len = ds.GetMassFunction(start, end).Length;

            double[] value;
            value = new double[len];



            value = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("+     X     +    f(X)   +");
            Console.WriteLine("+-----------+-----------+");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,5:f2}    |" , start, value[i]);
                start++;
            }
            Console.WriteLine("+-----------+-----------+");
        }
    }
}
