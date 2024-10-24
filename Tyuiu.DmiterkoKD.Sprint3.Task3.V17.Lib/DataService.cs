using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DmiterkoKD.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    result += c;
                }
            }
            int number = Int32.Parse(result);
            return number;
        }
    }
}
