namespace JsonSerilizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Enter mark: ");
            string mark = Console.ReadLine();

            if(mark == "+")
            {
                Calculate(input);
            }else if(mark == "*")
            {
                Product(input);
            }

        }
        static void Calculate(int number)
        {
            int resultCalculate = 0;
            
                for(int i = 0; i <= number; i++)
                {
                    resultCalculate += i;
                }
                Console.WriteLine($"Result: {resultCalculate}");
            
        }
        static void Product(int number)
        {
            int resultProduct = 1;

            
                for (int i = 1; i <= number; i++)
                {
                    resultProduct *= i;
                }
                Console.WriteLine($"Result: {resultProduct}");
            
        }
    }
}