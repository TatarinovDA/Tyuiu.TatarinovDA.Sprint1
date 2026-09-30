using Tyuiu.TatarinovDA.Sprint1.Task5.V6.Lib;
//Написать программу, которая решает следующую задачу:
//Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от того,
//на какой день недели (понедельник, вторник,..., воскресенье) приходится k-й день невисокосного года,
//в котором 1 января – понедельник.
namespace Tyuiu.TatarinovDA.Sprint1.Task4.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной                 *");
            Console.WriteLine("* n значение 1,2,...,7 в зависимости от того,                             *");
            Console.WriteLine("* на какой день недели(понедельник, вторник,..., воскресенье)             *");
            Console.WriteLine("* приходится k-й день невисокосного года, в котором 1 января – понедельник*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день года (k) от 1 до 365: ");
            int k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(k);

            string dayName = "";
            switch (result)
            {
                case 1: dayName = "Понедельник"; break;
                case 2: dayName = "Вторник"; break;
                case 3: dayName = "Среда"; break;
                case 4: dayName = "Четверг"; break;
                case 5: dayName = "Пятница"; break;
                case 6: dayName = "Суббота"; break;
                case 7: dayName = "Воскресенье"; break;

            }
            Console.WriteLine($"* День недели(n) : {result} ({dayName})");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}