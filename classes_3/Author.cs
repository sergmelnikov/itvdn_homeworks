using System;
namespace classes_3
{
    public class Author
    {
        readonly string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Author is {0}", author);
        }

    }
}
