class Program
{
    static void Main()
    {
        int counter = 0;
        int current = 2000;
        do
        {
            HashSet<char> nums = new HashSet<char>();
            for (int i=0; i < 4; i++)
            {
                nums.Add(current.ToString()[i]);
            }
            if (nums.Count()==4)
            {
                counter++;
                Console.WriteLine(current.ToString());
            }
            current++;
        } while (current<=3000);
        Console.WriteLine(counter.ToString());
    }
}