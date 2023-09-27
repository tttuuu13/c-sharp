class Program
{
    static double DoOperation(int sign, double a, double b)
    {
        return sign switch
        {
            '+' => a+b,
            '-' => a-b,
            '*' => a*b,
            '/' => a/b,
        };
    }
    static void Main()
    {      
        char[] signs = {'+', '-', '*', '/'};
        foreach (char s1 in signs)
        {
            foreach (char s2 in signs)
            {
                foreach (char s3 in signs)
                {
                    foreach (char s4 in signs)
                    {
                        foreach (char s5 in signs)
                        {
                            string exp = $"((((1{s1}2){s2}3){s3}4){s4}5){s5}6";
                            double r = DoOperation(s5, DoOperation(s4, DoOperation(s3, DoOperation(s2, DoOperation(s1, 1, 2), 3), 4), 5), 6);
                            if (r==35)
                            {
                                Console.WriteLine($"{exp}=35");
                                return;
                            }
                            
                        }
                    }
                }
            }
        }
    }
}