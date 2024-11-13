using Tyuiu.GurzanVM.Sprint3.Task3.V17.Lib;

namespace Tyuiu.GurzanVM.Sprint3.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
            Console.WriteLine("* цифру затем преобразовать в число в строке: *vn98n! b,                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string value = "*vn98n! b,";
            int res = ds.ConvertStringToInt(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("После удаления всех букв и знаков препинания, осталось только число: " + res);
            Console.ReadKey();
        }
    }
}