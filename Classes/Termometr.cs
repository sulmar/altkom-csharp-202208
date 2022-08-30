using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Sensor
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Unit { get; set; }
    }

    public class Termometr : Sensor
    {
        public string Color { get; set; }

        public float GetMeasure()
        {
            return 100;
        }
    }

    public class PreasuseGauge : Sensor
    {        
        public float GetMeasure()
        {
            return 1024;
        }
    }

    public class Vehicle
    {
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int? Milage { get; set; }
    }

    public class Truck : Vehicle
    {
        public float Capacity { get; set; }
    }

    public class Car : Vehicle
    {               
        
    }




}
