using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій.
        // Написати програму, яка виводить на екран основні арифметичні операції.


        static class Calculator
        {
            static public void Add(double operand1, double operand2)
            {
                Console.WriteLine(operand1);
                Console.WriteLine("+");
                Console.WriteLine(operand2);
                Console.WriteLine(new string('-', 6));
                Console.WriteLine(operand1 + operand2);
                Console.WriteLine();
            }

            static public void Sub(double operand1, double operand2)
            {
                Console.WriteLine(operand1);
                Console.WriteLine("-");
                Console.WriteLine(operand2);
                Console.WriteLine(new string('-', 6));
                Console.WriteLine(operand1 - operand2);
                Console.WriteLine();
            }

            static public void Mul(double operand1, double operand2)
            {
                Console.WriteLine(operand1);
                Console.WriteLine("*");
                Console.WriteLine(operand2);
                Console.WriteLine(new string('-', 6));
                Console.WriteLine(operand1 * operand2);
                Console.WriteLine();
            }

            static public void Div(double operand1, double operand2)
            {
                Console.WriteLine(operand1);
                Console.WriteLine("/");
                Console.WriteLine(operand2);
                Console.WriteLine(new string('-', 6));

                if (operand2 != 0)
                    Console.WriteLine(operand1 / operand2);
                else
                    Console.WriteLine("Division by zero!");
                Console.WriteLine();
            }

            static public void Remainder(double operand1, double operand2)
            {
                Console.WriteLine(operand1);
                Console.WriteLine("%");
                Console.WriteLine(operand2);
                Console.WriteLine(new string('-', 6));
                Console.WriteLine(operand1 % operand2);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Calculator.Add(1, 2);
            Calculator.Div(1, 0);
            Calculator.Remainder(3, 2.1);
            Console.ReadKey();
        }
    }
}
