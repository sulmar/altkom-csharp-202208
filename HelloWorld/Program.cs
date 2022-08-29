namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            byte age = byte.Parse(Console.ReadLine());

            // Konkatenacja ciągów tekstowych
            // Console.WriteLine("Hello " + firstName + " " + lastName);

            // string message = "Hello " + firstName + " " + lastName;

            // string message = string.Format("Hello {0} {1} {2}", firstName, lastName, age);

            // Interpolacja
            string message = $"Hello {firstName} {lastName} {age}";

            Console.WriteLine(message);

        }        
    }
}