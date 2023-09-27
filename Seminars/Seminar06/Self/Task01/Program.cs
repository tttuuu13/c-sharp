class Program
{
    static void Main()
    {
        bool p=false, q=false;
        Console.WriteLine("  p     q     F  ");
        do
        {
            do
            {
                Console.Write(p.ToString() + " ");
                Console.Write(q.ToString() + " ");
                Console.WriteLine((!(p & q) & !(p||!q)).ToString());
                q=!q;
            } while (!(q==false));
            p=!p;
        } while (!(p==false&q==false));
    }
}

