using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Publication
    {     
        public DateOnly releaseDate;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
    }

    public class Newspaper : Publication
    {
        public string ISSN { get; set; }
    }

    internal class Book : Publication
    {
        public string ISBN { get; set; }

        public string authorName;

        public CoverType CoverType { get; set; } 
       

        public void ShowDetails()
        {
            Console.WriteLine($"{Title} {GetCoverTypeAsString()}");
        }

        //public Book(CoverType coverType)
        //{
        //    this.coverType = coverType;
        //}

        public string GetCoverTypeAsString()
        {
            switch (this.CoverType)
            {
                case CoverType.Hard: return "Twarda obwoluta"; break;
                case CoverType.Soft: return "Miękka obwoluta"; break;

                default: return "";
            }
        }

    }

    // Typ wyliczeniowy
    public enum CoverType
    {        
        Hard = 0,
        Soft = 1,
    }



}
