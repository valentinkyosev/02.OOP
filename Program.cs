using System;
using System.Collections.Generic;
namespace Деклариране_на_шаблонен_generic__метод
{
    class Program
    {
        static List<T> GetInitializedList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }
        static void Main()
        {
            List<bool> list1 = GetInitializedList(true, 5);
            List<string> list2 = GetInitializedList<string>("Perls", 3);
            foreach (bool value in list1)
            {
                Console.WriteLine(value);
            }
            foreach (string value in list2)
            {
                Console.WriteLine(value);
            }
        }
    }
}
   
