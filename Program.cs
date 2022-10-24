using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            firstPerson.Name = "Gosho";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();
            firstPerson.Age = 17;
            firstPerson.IntroduceYourself();

            firstPerson.Name = "Ivan";
            firstPerson.Age = 19;
            firstPerson.IntroduceYourself();
        }
    }
}
