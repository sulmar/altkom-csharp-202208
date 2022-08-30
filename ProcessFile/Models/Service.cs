using System.Diagnostics;
using System.Xml.Linq;

namespace ProcessFile.Models
{
    public class Service : Item
    {        
        public Service(TimeSpan duration, string name, decimal price)
            : base(name, price)
        {
            Duration = duration;
        }

        public TimeSpan Duration { get; set; }

       
    }
}
