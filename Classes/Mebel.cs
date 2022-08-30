namespace Classes
{
    public class Measure
    {
        public DateTime MeasureDate { get; set; }

        //public float VoltageL1 { get; set; }
        //public float PowerL1 { get; set; }
        //public float VoltageL2 { get; set; }
        //public float PowerL2 { get; set; }
        //public float VoltageL3 { get; set; }
        //public float PowerL3 { get; set; }

        //public Phase L1 { get; set; }
        //public Phase L2 { get; set; }
        //public Phase L3 { get; set; }

        public Phase[] Phases { get; set; }
    }

    public class Phase
    {
        public float Voltage { get; set; }
        public float Power { get; set; }
    }

    public class Rozmiar
    {
        public int dlugosc;
        public int szerokosc;
        public int wysokosc;

        public override string ToString()
        {
            return $"dł: {dlugosc}x{szerokosc}x{wysokosc}";
        }
    }

    public class Lodowka
    {
        public Rozmiar Rozmiar { get; set; }
    }

    public abstract class Mebel
    {
        public Rozmiar Rozmiar { get; set; }

        public int waga;
        public string material;
        public string kolor;

        public void Zaprezentuj()
        {
            // TODO: 
        }
    }

    public class Regal : Mebel
    {
        public int IloscPolek { get; set; }
        public Szuflada Szuflada { get; set; }
    }

    public class Biurko : Mebel
    {
        public Szuflada Szuflada { get; set; }
    }

    public class Szuflada
    {
        public float Pojemnosc { get; set; }
    }




}
