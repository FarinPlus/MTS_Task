class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 8, 18, 12, 5, 14, 21, 8,13, 15,82,12,10};
        int maxValue = 23;
        int sortFactor = 5;
        var sorted1 = Sort(list, sortFactor, maxValue);
        foreach (var x in sorted1) Console.Write(x + " ");

    }

    static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
    {
        List<int> sortt = new List<int>();
        int max = -1;
        foreach (int item in inputStream)
        {
            if (item <= maxValue)
            {
                if (item > max)
                {
                    sortt.Add(item);
                    max = item-sortFactor;
                }
            }
        }
        sortt.Sort();
        return sortt;

    }
}
