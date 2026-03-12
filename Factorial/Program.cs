class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number or q: ");
            string input = Console.ReadLine();

            if (input == "q")
                break;

            int num = int.Parse(input);
            long fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of {0} is {1}", num, fact);
            Console.WriteLine();
        }
    }
}