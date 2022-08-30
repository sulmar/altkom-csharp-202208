using System.Diagnostics;
using System.Xml.Linq;

namespace ProcessFile.Models
{
    public class Product : Item
    {
        private const int BarCodeSize = 7;

        public Product(string barCode, string color, string name, decimal price)
            : base(name, price)
        {
            BarCode = barCode;
            Color = color;
        }


        // product1.BarCode = "12345";

        //public void SetBarCode(string value)
        //{
        //    barcode = value;
        //}

        //public string GetBarCode()
        //{
        //    return barcode;
        //}

        private string barcode;
        public string BarCode 
        { 
            get
            {
                return barcode;
            }
            set
            {
                if (value.Length != BarCodeSize)
                {
                    throw new FormatException($"Kod kreskowy powinien mieć {BarCodeSize} znaków.");
                }

                barcode = value;
            }
        }
        
        public string Color { get; set; }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} {BarCode} {Color}";
        }
    }
}
