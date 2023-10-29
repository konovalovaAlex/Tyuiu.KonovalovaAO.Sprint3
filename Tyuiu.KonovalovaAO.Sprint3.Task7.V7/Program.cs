using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint3.Task7.V7.Lib;
namespace Tyuiu.KonovalovaAO.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = cos(x) + cos(x) / x + 2 - 3 * x  (произвести табулирование) f(x)*");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на *");
            Console.WriteLine("* ноль. При делении на ноль вернуть 0. Значения округлить до двух        *");
            Console.WriteLine("* знаков после запятой.                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int Start = -5;
            int Stop = 5;
            Console.WriteLine("Начальное значение = " + Start);
            Console.WriteLine("Конечное значение = " + Stop);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            int X = Start;
            foreach (double i in ds.GetMassFunction(Start, Stop))
            {
                Console.WriteLine("|{0,10:d}|{1,10:f2}|", X, i);
                X++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
