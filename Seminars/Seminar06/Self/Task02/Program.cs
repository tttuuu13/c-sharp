class Program
{
    static void Main()
    {
        Console.WriteLine("  A     B     C     F");
        bool a=false, b=false, c=false;
        do
        {
            do
            {
                do
                {
                    bool f = !(a || b && c) || a;
                    Console.WriteLine(a.ToString() + ' ' + b.ToString() + ' ' + c.ToString() + ' ' + f.ToString());
                    a=!a;
                } while (!(a==false));
            b=!b;
            } while (!(b==false));
        c=!c;
        } while (!(c==false));
    }
}