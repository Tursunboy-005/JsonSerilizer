namespace JsonSerilizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double input = double.Parse(Console.ReadLine());
            //Console.Write("Enter mark: ");
            //string mark = Console.ReadLine();

            //if(mark == "+")
            //{
            //    Calculate(input);
            //}else if(mark == "*")
            //{
            //    Product(input);
            //}
            Thread thread = new Thread(() => Calculate(input));
            Thread thread1 = new Thread(() => Product(input));
            
            thread.Start();
            thread1.Start();

            Main(args);
        }
        static void Calculate(double number)
        {
            double resultCalculate = 0;
            
                for(double i = 0; i <= number; i++)
                {
                    resultCalculate += i;
                }
                Console.WriteLine($"{Thread.CurrentThread.Name} \n resultCalculate: {resultCalculate}");
            
        }
        static void Product(double number)
        {
            double resultProduct = 1;

            
                for (double i = 1; i <= number; i++)
                {
                    resultProduct *= i;
                }
                Console.WriteLine($"{Thread.CurrentThread.Name} \n resultProduct : {resultProduct}");
            
        }
    }
}
// EDAUZ0696
// UZB6TR6Y