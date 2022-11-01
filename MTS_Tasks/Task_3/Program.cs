public static class Program
{
    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        var result = new List<(T, int?)>();
        var first = enumerable.GetEnumerator();
        var sec = enumerable.GetEnumerator();
        int i = 0;
        while (i < tailLength && sec.MoveNext())i++;
        while (sec.MoveNext())
        {
            first.MoveNext();
            result.Add((first.Current, null));
        }
        first.MoveNext();
        for (int j = (int)tailLength - 1; j >= 0; --j)
        {
            result.Add((first.Current, j));
            first.MoveNext();
        }
        return result;
    }
    public static void Main(string[] args)
    {
        int[] mas = new[] {1,2,3,4,5,6,7,8};
        var enumtail = mas.EnumerateFromTail(3);
        foreach (var x in enumtail)
            Console.Write(x + " ");
    }
}
