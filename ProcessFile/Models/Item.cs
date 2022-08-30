using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessFile.Models
{

    public class Item
    {        
                        
        private string name;

        public string Name
        {
            set => name = value;    // wyrażenie lambda
            get => name;
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
                    throw new ArgumentOutOfRangeException("Cena na nie może być poniżej 0");

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

        public DateTime ModifiedDate { get; set; }
      

        // Konstruktor - służy do utworzenia obiektu
        public Item(string name, decimal price)
        {            
            this.name = name;
            this.Price = price;

            createdDate = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{name} {price:C2}";
        }

        public void Remove()
        {
            isRemoved = true;
            removedDate = DateTime.Now;
        }

        public virtual string GetDescription()
        {
            return $"{name} {price:C2}";
        }
    }
}
