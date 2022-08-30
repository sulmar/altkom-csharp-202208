using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Book
    {
        public string authorName;
        public DateOnly releaseDate;
        public string Title { get; set; }
        public string Description { get; set; }
        public CoverType CoverType { get; set; } 
        public string Publisher { get; set; }

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

    internal class Telefon
    {
        public string marka;
        public string model;
        public int rokZakupu;

        public void Display()
        {
            Console.WriteLine($"{Wiek()} {marka} {model}");
        }

        public int Wiek()
        {
            return DateTime.Today.Year - rokZakupu;
        }
    }

    internal class Car
    {
        public string Marka;
        public string Model;
        public int Rocznik { get; set; }
        public int? Przebieg { get; set; }

        public void Display()
        {
            if (Przebieg.HasValue)
            {
                
            }
        }
    }

    internal class Clock
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
