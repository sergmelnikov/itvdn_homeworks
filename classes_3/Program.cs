using System;

namespace classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book("Мастер и Маргарита", "М. А. Булгаков", "Содержание");
            newBook.Show();         
        }
    }
}
