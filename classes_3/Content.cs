using System;
namespace classes_3
{
    public class Content
    {
        readonly string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Content is {0}", content);
        }
    }
}
