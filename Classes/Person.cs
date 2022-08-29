using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Klasa -> obiekt (instancja klasy)
    internal class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Gender gender;

        // Metoda
        public void Greet()
        {
            Console.WriteLine($"{this.firstName} {this.lastName} {this.age}");
        }
    }

    public enum Gender
    {
        Male,
        Female
        
    }
}
