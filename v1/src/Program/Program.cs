using System;
using System.Text.Json;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            IJsonConvertible person = new Person("Diego", "Lugano");
            Console.WriteLine(person.ConvertToJson());

            Person person2 = new Person("{\"Name\":\"Diego\",\"FamilyName\":\"Godín\"}");
            Console.WriteLine(person2.ConvertToJson());
        }
    }
}