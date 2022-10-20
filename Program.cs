using System;

namespace Деклариране_на_шаблонен_generic__клас
{
    class Test<T>
    {
        T _value;

        public Test(T t)
        {
            this._value = t;
        }
        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }

    class Program
    {
        static void Main()
        {
            Test<int> test1 = new Test<int>(5);
            test1.Write();

            Test<string> test2 = new Test <string> ("cat");
            test2.Write();
        }

    }
}