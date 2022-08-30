using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProcessFile.IServices;
using ProcessFile.Models;

namespace ProcessFile.Services
{

    public class CsvItemService : IItemService    // CsvItemService implementuje IItemService
    {
        string filename;
        char separator;

        public CsvItemService(string filename, char separator = ',')
        {
            this.filename = filename;
            this.separator = separator;
        }

        // public - ta metoda dostępna będzie również poza klasą CsvItemService
        public Item[] Get()
        {           
            // Tablica
            // string content = File.ReadAllText(filename);

            // Załadowanie listy produktów
            string[] lines = File.ReadAllLines(filename);

            Item[] items = new Item[lines.Length - 1];

            int i = 0;

            // Iteracja po elementach tablicy
            foreach (string line in lines.Skip(1))
            {
                items[i++] = Map(line);
            }

            return items;
        }

        // private - ta metoda dostępna będzie tylko z klasy CsvItemService
        private Item Map(string line)
        {
            CultureInfo culture = new CultureInfo("en");

            // Rozdzielenie tekstu na tablicę
            string[] columns = line.Split(separator);

            string barCode = columns[0];
            string name = columns[1];
            string color = columns[2];
            decimal price = decimal.Parse(columns[3], culture);

            Item item = new Item(barCode, name, price);
            item.Price = price;

            return item;
        }
    }
}
