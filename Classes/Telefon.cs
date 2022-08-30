namespace Classes
{
    public class Camera
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public float Focus { get; set; }
    }

    public class Batery
    {
        public float Capacity { get; set; }
        public float Volume { get; set; }
    }

    public class Smartphone : CellPhone
    {      
        public bool hasMemoryCard { get; set; }
    }

    public class CellPhone : Phone
    {
        public Camera Camera { get; set; }
        public Batery Batery { get; set; }
    }

    public abstract class Phone
    {
        public string marka;
        public string model;
        public int rokZakupu;

        public float Volume { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Wiek()} {marka} {model}");
        }

        public int Wiek()
        {
            return DateTime.Today.Year - rokZakupu;
        }

        public void Call(string number)
        {
            Console.WriteLine(number);
        }
    }



}
