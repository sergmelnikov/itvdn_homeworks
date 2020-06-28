using System;
namespace classes_3
{
    public class Title
    {
        readonly string title;
         
        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title is {0}", title);
        }
    }
}
