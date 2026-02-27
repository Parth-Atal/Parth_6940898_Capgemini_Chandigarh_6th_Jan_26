using System.ComponentModel;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cs = new Calculator();

            int input1 = Convert.ToInt32(Console.ReadLine());

            int input2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Sum: " + cs.Add(input1, input2));
            Console.WriteLine("Sub: " + cs.Sub(input1, input2));
            Console.WriteLine("Product: " + cs.Mul(input1, input2));
            Console.WriteLine("Quotient: " + cs.div(input1, input2));
        }
    }
}
