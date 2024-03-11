class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("druga modyfikacja - test");

        int[] tablica = { 1, 3, 5, 10, 8 };
        Console.WriteLine(Average(tablica));
    }
    
    public static int Average(int[] tab)
    {
        int average = 0;
        foreach (int num in tab)
        {
            average += num;
        }

        average = average / tab.Length;
        return average;
    }
}
