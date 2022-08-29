using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessFile
{
    internal class Item
    {
        public string barCode;
        public string name;
        public string color;
        public decimal price;

        public DateTime createdDate;

        const int BarCodeSize = 7;
        
        // Konstruktor - służy do utworzenia obiektu
        public Item(string barCode, string name, decimal price)
        {
            if (barCode.Length != BarCodeSize)
            {
                throw new FormatException($"Kod kreskowy powinien mieć {BarCodeSize} znaków.");                
            }

            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException("Cena na nie może być poniżej 0");
            }

            this.barCode = barCode;
            this.name = name;
            this.price = price;

            this.createdDate = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{this.barCode} {this.name} {this.color} {this.price:C2}";            
        }
    }
}
