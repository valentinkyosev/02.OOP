using System;
using System.Collections.Generic;
using System.Text;

namespace ex01
{
    class Person
    {
        private string name;
        private int age;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравей! Аз съм {0} и съм на {1} години.", name, age);
        }
    }
}
