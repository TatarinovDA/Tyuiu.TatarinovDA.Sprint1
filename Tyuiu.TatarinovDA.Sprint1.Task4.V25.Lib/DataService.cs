using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TatarinovDA.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            double result = (1 - Math.Cos(a)) / Math.Pow(Math.Sin(a), 2);
            return Math.Round(result,3);
        }
    }
}
