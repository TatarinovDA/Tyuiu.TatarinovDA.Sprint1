using Tyuiu.TatarinovDA.Sprint1.Task6.V1.Lib;

//Напишите программу, которая выводит код введенного пользователем символа.
//Программа должна завершать работу в результате ввода, например, точки.
//Рекомендуемый вид экрана во время выполнения программы приведен ниже.
//Введите символ и нажмите <Enter>. 
//Для завершения введите точку. 
//-> 1
//Символ: 1 Код: 49
//-> .

namespace Tyuiu.TatarinovDA.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
            Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
            Console.WriteLine("* Рекомендуемый вид экрана во время выполнения программы приведен ниже.   *");
            Console.WriteLine("* Введите символ и нажмите <Enter>.                                       *");
            Console.WriteLine("* Для завершения введите точку. -> 1  Символ: 1 Код: 49  -> .             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                if (input[0] == '.')
                {
                    break;
                }
                string codeResult = ds.SymbolCode(input);
                Console.WriteLine($"Символ: {input[0]} Код: {codeResult}");
            }
        }
    }
}
