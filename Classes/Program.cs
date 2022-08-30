namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Book book1 = new Book();
            book1.authorName = "John Smith";
            book1.ISBN = "4454435345";
            book1.CoverType = CoverType.Hard;

            // Tworzenie obiektu za pomocą inicjalizatorów
            Book book3 = new Book
            {
                authorName = "John Smith",
                ISBN = "4454435345",
                CoverType = CoverType.Hard,
                Publisher = "WNT",
            };

            //string firstName1 = "Marcin";
            //string lastName1 = "Sulecki";
            //byte age1 = 18;
            // Greet(firstName1, lastName1, age1);

            string weather = "sunny";

            //string firstName2 = "John";
            //string lastName2 = "Smith";
            //byte age2 = 21;
            // Greet(firstName2, weather, age2);


            // Utworzenie instacji klasy (powstaje obiekt)
            Person person1 = new Person();
            person1.firstName = "Marcin";
            person1.lastName = "Sulecki";
            person1.age = 18;
            person1.Greet();

            Person person2 = new Person();
            person2.firstName = "John";
            person2.lastName = "Smith";
            person2.age = 21;
            person2.Greet();


            
        }

        static void Greet(string firstName, string lastName, byte age)
        {
            Console.WriteLine($"{firstName} {lastName} {age}");
        }
    }
}