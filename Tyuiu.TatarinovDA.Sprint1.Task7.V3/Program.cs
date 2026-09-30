using Tyuiu.TatarinovDA.Sprint1.Task7.V3.Lib;
//Написать программу, которая вычисляет математическое
//выражение по исходным значениям данных, вводимых пользователем.
//Ответ округлите до 3 знаков после запятой.
namespace Tyuiu.TatarinovDA.Sprint1.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое                    *");
            Console.WriteLine("* выражение z = (3 +e^(y-1)) / (1 + x^2 * |y - tg(x)|)                    *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.Calculate(x, y);
            Console.WriteLine($"\n Результат: z = {result:F3}");
            
            Console.WriteLine("***************************************************************************");
            
            Console.ReadKey();
        }
        }
    
}