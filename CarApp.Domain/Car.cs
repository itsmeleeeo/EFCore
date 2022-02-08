using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Domain
{
    public class Car
    {
        public Car()
        {
            Manufacturers = new List<Manufacturer>();
        }
        public int Id { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public List<Manufacturer> Manufacturers { get; set;}
    }
}
