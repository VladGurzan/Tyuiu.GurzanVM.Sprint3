using Tyuiu.GurzanVM.Sprint3.Task0.V4.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task0.V4
{
    class Progeam
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " +  stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        
        
        
        
        }
    }
}