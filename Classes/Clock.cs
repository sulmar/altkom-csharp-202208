namespace Classes
{
    public class ElectronicClock : Clock
    {
        public Batery Batery { get; set; }
    }

    public class AnalogClock : Clock
    {

    }

   
    public abstract class Clock
    {
        public string name;
        public string color;
        public int diemeter; // średnica
        public int height;

        public void Print()
        {

        }
    }



}
