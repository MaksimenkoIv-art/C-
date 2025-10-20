using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 50;
            Console.WriteLine($"Значение x до изменения: {x}");

            int* p = &x;
            int** pp = &p;

            Console.WriteLine($"Адрес переменной x: 0x{(ulong)&x:X}");
            Console.WriteLine($"Адрес указателя p: 0x{(ulong)&p:X}");

            **pp = 999;
            Console.WriteLine($"Значение x после изменения через pp: {x}");
        }
    }
}
