class Program
{
    static void Main()
    {
        if (!(double.TryParse(Console.ReadLine(), out double a)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (!(int.TryParse(Console.ReadLine(), out int n)))
        {
            Console.WriteLine("Wrong input");
            return;
        }
        
    }
}