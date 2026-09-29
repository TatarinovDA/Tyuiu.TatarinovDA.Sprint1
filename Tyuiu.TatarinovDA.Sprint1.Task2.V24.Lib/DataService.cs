using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TatarinovDA.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int x, int y)
        {
            return Convert.ToInt32(Math.Pow(x - y,2));
        }
    }
}
