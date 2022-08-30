using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessFile.IServices;
using ProcessFile.Models;

namespace ProcessFile.Services
{

    internal class CsvItemService : IItemService    // CsvItemService implementuje IItemService
    {
        string filename;
        char separator;

        public CsvItemService(string filename, char separator = ',')
        {
            this.filename = filename;
            this.separator = separator;
        }

        

        public Item[] Get()
        {           
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

                string barCode = columns[0];
                string name = columns[1];
                string color = columns[2];
                decimal price = decimal.Parse(columns[3], culture);

                Item item = new Item(barCode, name, price);
                item.price = price;

              

                items[i++] = item;
            }

            return items;
        }
    }
}
