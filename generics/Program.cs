using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // where are all Generic Collections located in .NET?
            // System.Collections.Generic.

            // while using generics there is not casting or boxing

            // generic list
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            // generic dictionary
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            // using class with value constraint
            var num = new Nullable<int>(5);
            System.Console.WriteLine("Has Value? " + num.HasValue);
            System.Console.WriteLine("Value: " + num.GetValueOrDefault());

            var numNull = new Nullable<int>();
            System.Console.WriteLine("Has Value? " + numNull.HasValue);
            System.Console.WriteLine("Value: " + numNull.GetValueOrDefault());
        }
    }
}
