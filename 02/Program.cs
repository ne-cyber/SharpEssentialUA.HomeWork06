using System;
using System.Collections.Generic;
using System.Text;

namespace _02
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) для пошуку
        // за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться послідовний пошук рядка в книзі.

        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Пошук рядка : " + str);
            }
        }


        static class FindAndReplaceMananager
        {
            private static Book book;
            public static Book Book { get { return book; } set { book = value; } }

            static public void FindNext(string str)
            {
                if (book != null)
                    book.FindNext(str);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Book book = new Book();

            FindAndReplaceMananager.Book = book;
            FindAndReplaceMananager.FindNext("Зміст");


            Console.ReadKey();
        }
    }
}
