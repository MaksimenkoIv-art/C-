using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.Write("До: ");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();

            fixed (int* p = numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                    *(p + i) += 10;
            }

            Console.Write("После: ");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}