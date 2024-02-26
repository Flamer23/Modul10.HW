using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.HW
{
    internal class Calculator : ICalculator, ILogger
    {
        public void Calc (int a, int b)
        {
            Console.WriteLine($"Результат: {a+b}");
        }

        public void Log(string message) 
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ОШИБКА!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
