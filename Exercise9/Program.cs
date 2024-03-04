namespace Exercise9
{
    class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer number:");
        string a = Console.ReadLine();
        var result1 = Convert.ToInt32(a);
        var result2 = SumOfPolygon(result1);
        Console.WriteLine("Total sum of polygon angles is:" + result2);
    }

    public static int SumOfPolygon(int a)
    {
            return (a - 2) * 180;
    }
}

}