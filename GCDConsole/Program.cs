using NaturalNumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GCDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите первое число: ");
            int First = int.Parse(ReadLine());

            WriteLine("Введите второе число: ");
            int Second = int.Parse(ReadLine());

            int Gcd = NaturalNumbers.GCD(First, Second);

            WriteLine($"НОД({First}, {Second}) = {Gcd}");
            ReadLine();
        }
    }
}
