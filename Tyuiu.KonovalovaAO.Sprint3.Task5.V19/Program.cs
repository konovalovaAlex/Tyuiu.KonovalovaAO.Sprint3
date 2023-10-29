using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint3.Task5.V19.Lib;
namespace Tyuiu.KonovalovaAO.Sprint3.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле, при x = 2 *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 2;
            int strtv1 = 1;
            int stpv1 = 3;
            int strtv2 = 1;
            int stpv2 = 6;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + strtv1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stpv1);
            Console.WriteLine("Старт шага второй суммы ряда = " + strtv2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stpv2);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, strtv1, strtv2, stpv1, stpv2));
            Console.ReadKey();

        }
    }
}
