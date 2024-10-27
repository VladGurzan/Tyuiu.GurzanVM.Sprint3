﻿using Tyuiu.GurzanVM.Sprint3.Task4.V20.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x) - x)+2,5\r\n\r\nПри х = 0 пропустить значение.      *");
            Console.WriteLine("* Полученные значения перемножать                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + startValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("сумма ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}