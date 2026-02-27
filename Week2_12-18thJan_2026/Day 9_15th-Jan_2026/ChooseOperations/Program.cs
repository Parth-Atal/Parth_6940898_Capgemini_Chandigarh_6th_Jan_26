namespace ChooseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2, output = 0, choice;

            Console.Write("Enter the first number: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            if(input1 < 0 && input2 < 0)
            {
                output = -1;
                Console.WriteLine("Output: " + output);
                return;
            }

            Console.WriteLine("Enter the choice of operation you wish to perform: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Input: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    output = input1 + input2;
                    break;

                case 2:
                    output = input1 - input2;
                    break;

                case 3:
                    output = input1 * input2;
                    break;

                case 4:
                    if(input2 == 0)
                    {
                        output = -1;
                    }
                    else
                    {
                        output = input1 / input2;
                    }

                    break;
            }

            Console.WriteLine("Output: " + output);

        }
    }
}
