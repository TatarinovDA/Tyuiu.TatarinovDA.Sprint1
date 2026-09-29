using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TatarinovDA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {

        public bool ZeroCheck(double number)
        {
            double absNumber = Math.Abs(number);
            double integerPart = Math.Truncate(absNumber);
            double fractionalPart = absNumber - integerPart;
            for (int i = 0; i< 3; i++)
            {
                fractionalPart *= 10;
                int digit = (int)fractionalPart;
                if (digit == 0) return true;
                fractionalPart -= digit;
            }
            return false;
        }
    }
}
