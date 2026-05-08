using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal class Vehicle
    {
        public int Id { get; private set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public Vehicle(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }
    }
}
