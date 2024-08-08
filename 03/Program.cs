using System;
using System.Collections.Generic;
using System.Text;

namespace _03
{
    internal class Program
    {
        // Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        // Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes,
        // який дозволить зберігати нотатки читача.


        #region варіант 1
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Пошук рядка : " + str);
            }



            private string[] notes = new string[0];

            public void AddNote(string note)
            {
                Notes notes = new Notes();
                notes.AddNote(this, note);
            }

            private class Notes
            {
                public void AddNote(Book book, string note)
                {
                    Array.Resize(ref book.notes, book.notes.Length + 1);
                    book.notes[book.notes.Length - 1] = note;
                }
            }
        }
        #endregion варіант 1


        // АБО
        

        #region варіант 2
        //class Book
        //{
        //    public void FindNext(string str)
        //    {
        //        Console.WriteLine("Пошук рядка : " + str);
        //    }


        //    private string[] notes = new string[0];
            
        //    public static class Notes
        //    {
        //        public static void AddNote(Book book, string note)
        //        {
        //            Array.Resize(ref book.notes, book.notes.Length + 1);
        //            book.notes[book.notes.Length - 1] = note;
        //        }
        //    }
        //}
        #endregion варіант 2



        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddNote("note 1");

            //Book book = new Book();
            //Book.Notes.AddNote(book, " note 1");


            Console.ReadKey();
        }
    }
}
