class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");
    }

    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        Console.SetOut(new StreamWriter("out.txt"));
    }
}
