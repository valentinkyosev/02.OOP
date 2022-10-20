using System;

namespace Статичен_конструктор
{
    public class Program
    {
        public static void Main()
        {
            StopWatch.DisplayInfo();
            StopWatch.DisplayInfo();
        }
    }
    public class StopWatch
    {
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }
        public void Start()
        { }
        public void Stop()
        { }
    }
}
