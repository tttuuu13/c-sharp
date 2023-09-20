class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int i=0; int d=0; int o=0;
        while (!(input=="0"||input=="-0"))
        {
            if (int.TryParse(input, out int r1))
            {
                i++;
            }
            else if (double.TryParse(input, out double r2))
            {
                d++;
            }
            else
            {
                o++;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(o);
    }
}