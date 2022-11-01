using System.Globalization;

class Program
{
    static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

    class Number
    {
        readonly int _number;
        public Number(int number)
        {
            _number = number;
        }
        public static string operator +(Number x, string y)
        {
            return (x._number + Convert.ToInt32(y)).ToString();
        }
        public override string ToString()
        {
            return _number.ToString(_ifp);
        }
    }
    static void Main(string[] args)
    {
        int someValue1 = 10;
        int someValue2 = 5;
        string result = new Number(someValue1) + someValue2.ToString(_ifp);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

