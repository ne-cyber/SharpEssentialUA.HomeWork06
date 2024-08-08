using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    // Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 

    static class ExtensionClass
    {
        static public void SortAsc(this int[] arr)
        {
            Array.Sort(arr);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1 };
            arr.SortAsc();

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]");

            Console.ReadKey();
        }
    }
}
