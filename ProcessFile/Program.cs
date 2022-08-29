using System.Globalization;

namespace ProcessFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Process File!");

            const string filename = "Items.csv";
            const char separator = ',';

            CultureInfo culture = new CultureInfo("en");

            // Tablica
            // string content = File.ReadAllText(filename);

            // Załadowanie listy produktów
            string[] lines = File.ReadAllLines(filename);

            Item[] items = new Item[lines.Length - 1];

            int i = 0;

            // Iteracja po elementach tablicy
            foreach (string line in lines.Skip(1))
            {
                // Rozdzielenie tekstu na tablicę
                string[] columns = line.Split(separator);

                Item item = new Item();
                item.barCode = columns[0];
                item.name = columns[1];
                item.color = columns[2];
                item.price = decimal.Parse(columns[3], culture);

                items[i++] = item;                
            }

            // Wyświetlenie listy produktów
            for(i = 0; i < items.Length; i++)
            {
                Item item = items[i];

                Console.WriteLine($"{item.barCode} {item.name} {item.color} {item.price}");
            }

        }
    }
}