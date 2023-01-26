using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        { 
        
        }
        public Car(string make, string model, string color, int year) 
        { 
            Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
