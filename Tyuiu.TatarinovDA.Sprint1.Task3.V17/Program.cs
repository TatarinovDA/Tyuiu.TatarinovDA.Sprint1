using Tyuiu.TatarinovDA.Sprint1.Task3.V17.Lib;
//Написать программу, которая определяет,
//есть ли среди первых трех цифр из дробной части заданного вещественного числа цифра 0.
namespace Tyuiu.TatarinovDA.Sprint1.Task3.V17
{
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.Title = "Спринт #1 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех цифр  *");
        Console.WriteLine("* из дробной части заданного вещественного числа цифра 0.                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите вещественное число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        bool result = ds.ZeroCheck(number);
            if (result)
                Console.WriteLine("Среди первых трёх цифр дробной части есть 0.");
            else 
                Console.WriteLine("Среди первых трёх цифр дробной части нет 0.");

        Console.ReadLine();
    }
}
}