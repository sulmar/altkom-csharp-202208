using ProcessFile.IServices;
using ProcessFile.Models;
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

            CsvItemService itemService = new CsvItemService(filename, ',');
            // IItemService itemService = new DbItemService("server=local;database=items;...");
            // IItemService itemService = new XmlItemService();

            itemService.Get();

            Item[] items = itemService.Get();

            Item item = items[0];
            item.Price = 100;
            //Console.WriteLine(item.BarCode);

            Console.WriteLine(item.Price);

            item.Remove();            
            
            Display(items);

            IncrementPrices(items, ratio);            

            Display(items);

        }

        static void IncrementPrices(Item[] items, decimal ratio)
        {
            foreach (Item item in items)
            {
                // item.price = item.price + item.price * 0.1m;
                item.Price += item.Price * ratio;
            }
        }        

        static void Display(Item[] items)
        {
            foreach (Item item in items)
            {
                //if (item is Product)
                //{
                //    Product product = item as Product;
                //}

                //if (item is Product product)
                //{
                //    ((Product)item).GetDescription();
                //}
                //else if (item is Service service)
                //{
                //    ((Service)item).GetDescription();
                //}

                Console.WriteLine(item.GetDescription());


            }
        }
    }
}