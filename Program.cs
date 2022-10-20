using System;

namespace Пример_за_Шаблонен_generic__метод
{
    public class Program
    {
        public static void Main()
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpate(0, "Mumbai");
            cities.AddOrUpate(1, "Chicago");
            cities.AddOrUpate(2, "London");

            Console.WriteLine(cities.GetData(100));

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine(empIds.GetData(0));
        }
    }
    class DataStore<T>
    {
        private T[] _data = new T[10];
        public void AddOrUpdate(int index, T item)
        {
            public void AddOrUpdate(int index, T item)
            {
                if (index >= 0 && index < 10)
                    _data[index] = item;
            }
            public T GetData(int index)
            {
                if (index >= 0 && index < 10)
                    return [index] = item;
                else
                    return default(T);
            }
        }
    }
}
  
