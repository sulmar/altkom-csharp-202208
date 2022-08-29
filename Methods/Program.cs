namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet("Marcin", "Sulecki");
            Greet("John", "Smith");
            Greet("Ann", "Smith");
            Greet("Bart", "Sulecki");
            Greet("Kate", "Sulecka");

            Greet(name: "Marcin", lastName: "Sulecki");

            int result = Square(2);

            Console.WriteLine(result);
        }

        // Wykonanie jakiegoś zadania
        static void Greet(string name, string lastName)
        {
            Console.WriteLine($"Hello, {name} {lastName}!");
        }

        static void Greet(string name, string lastName, string middleName = "", int age = 18)
        {
            Console.WriteLine($"Hello, {name} {lastName} {age}!");
        }

        // Obliczanie wartości
        static int Square(int number)
        {
            return number * number; 
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}