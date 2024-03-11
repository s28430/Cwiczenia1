class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        string str = "ala ma kota";
        
        Console.WriteLine(str);
        int x = 12;

        int[] arr = { 1, 5, 2, 6, 1 };
        Console.WriteLine(GetMax(arr));
    }

    private static double GetAverage(int[] array)
    {
        int total = 0;
        foreach (int n in array)
            total += n;
        return (double) total / array.Length;
    }

    private static int GetMax(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];
        return max;
    }
}