using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TatarinovDA.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            char symbol = value[0];
            int code = (int)symbol;
            return code.ToString();
        }
    }
}
