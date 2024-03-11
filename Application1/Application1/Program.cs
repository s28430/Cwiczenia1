class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        string str = "ala ma kota";
        
        Console.WriteLine(str);
        int x = 12;
    }

    private static double GetAverage(int[] array)
    {
        int total = 0;
        foreach (int num in array)
            total += num;
        return (double) total / array.Length;
    }
}