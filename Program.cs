using System;

namespace Статични_методи
{
    class Program
    {
        static int counter = 0;
        string name = "Demo Program";

        static void Main(string[] args)
        {
            counter++;
            Display("Hello World!")

                name = "New emo Program";
            SetRootFolder("C: \MyProgram");
        }
        static void Display(string text)
        {
            Console.WriteLine(text);
        }
        public void SetRootFolder(string path)
        { }
    }
}