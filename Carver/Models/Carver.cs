using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal class Carver : Vehicle
    {
        public CarverModelType ModelType { get; set; }

        public Carver(CarverModelType modelType) : base("Carver", modelType.ToString())
        {
            ModelType = modelType;
        }
    }
}
