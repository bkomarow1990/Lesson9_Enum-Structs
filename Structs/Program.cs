using System;

namespace Structs
{
    struct Person // can`t inheritance from structs / classes, but can from interfaces
    {
        string name; // default
        int age;
        public Person(string name, int age) // ctor must be assigned all fields
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public override string ToString()
        {
            return $"Name: {name}\tAge: {age}"; 
        }
    }
    class Program
    {
        static void EneterPerson(ref Person person)
        {
            Console.WriteLine("Enter Name : ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            person.Age = Int32.Parse(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Person person = new Person("Ann",22);
            Console.WriteLine(person.Age);
            Person clone = person;
        }
    }
}
