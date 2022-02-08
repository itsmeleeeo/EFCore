using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp.Domain
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Factory { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
