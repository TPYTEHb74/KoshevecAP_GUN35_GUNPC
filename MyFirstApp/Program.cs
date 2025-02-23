class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.Write("Enter the '&' '|' '^' : ");
        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
    
        switch (s[0])
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("binary --> {0}", Convert.ToString(a & b, 2));
                Console.WriteLine("decimal --> {0}", Convert.ToString(a & b, 10));
                Console.WriteLine(" Hexadecimal --> {0}", Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine("binary --> {0}", Convert.ToString(a | b, 2));
                Console.WriteLine("decimal --> {0}", Convert.ToString(a | b, 10));
                Console.WriteLine(" Hexadecimal --> {0}", Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine("binary --> {0}", Convert.ToString(a ^ b, 2));
                Console.WriteLine("decimal --> {0}", Convert.ToString(a ^ b, 10));
                Console.WriteLine(" Hexadecimal --> {0}", Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }
    }
}
 