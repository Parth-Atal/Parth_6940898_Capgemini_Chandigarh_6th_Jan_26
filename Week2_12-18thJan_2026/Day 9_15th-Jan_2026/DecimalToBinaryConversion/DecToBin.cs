using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryConversion
{
    internal class DecToBin
    {
        static int[] Conversion(int num)
        {
            int k = 0;
            int[] temp = new int[32];

            while(num > 0)
            {
                temp[k] = num % 2;
                num /= 2;
                k++;
            }

            int[] bin = new int[k];

            for(int i = 0; i< k; i++)
            {
                bin[i] = temp[i];
            }

            Array.Reverse(bin);
            return bin;
        }

        static void Main()
        {
            int input1;
            Console.Write("Enter the number you wish to convert to Binary: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            int[] output;

            if(input1 < 0)
            {
                output = new int[1];
                output[0] = -1;
            }

            else
            {
                output = Conversion(input1);
            }

            Console.Write("Binary: ");
            for(int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }

            Console.WriteLine();
        }


    }
}
