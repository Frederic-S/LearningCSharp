using System;
using LearningCSharp.People;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "John";
            person.Age = 25;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
