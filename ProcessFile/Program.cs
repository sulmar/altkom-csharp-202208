using ProcessFile.Services;

namespace ProcessFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Process File!");

            const string filename = "Items.csv";
            
            decimal ratio = 0.1m;

            IItemService itemService = new CsvItemService(filename, ',');
            // IItemService itemService = new DbItemService("server=local;database=items;...");
            // IItemService itemService = new XmlItemService();

            Item[] items = itemService.Get();           

            Display(items);

            IncrementPrices(items, ratio);            

            Display(items);

        }

       
        


        static void IncrementPrices(Item[] items, decimal ratio)
        {
            foreach (Item item in items)
            {
                // item.price = item.price + item.price * 0.1m;
                item.price += item.price * ratio;
            }
        }

        static void Display(Item[] items)
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}