using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessFile.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string BarCode { get; private set; } 
        public string Title { get; set; }
                
        private string name;

        public string Name
        {
            set => name = value;    // wyrażenie lambda
            get => name;
        }


        private string color;
        public string Color
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }   
        }


        private decimal price;

        // Właściwość (Property)
        public decimal Price
        {
            // setter
            set
            {
                // Walidacja
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                price = value;
            }

            // getter
            get
            {
                return price;
            }
        }

       

        /*

        // Setter
        public void SetPrice(decimal value)
        {
            // Walidacja
            if (value < 0)
                throw new ArgumentOutOfRangeException();

            price = value;
        }

        // Getter
        public decimal GetPrice()
        {
            return price;
        }

        */



        private bool isRemoved;
        private DateTime? removedDate;

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

            this.BarCode = barCode;
            this.name = name;
            this.price = price;

            createdDate = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{BarCode} {name} {Color} {price:C2}";
        }

        public void Remove()
        {
            isRemoved = true;
            removedDate = DateTime.Now;
        }
    }
}
