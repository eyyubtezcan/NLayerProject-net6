using NLayerProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Domain.Entities
{
    public class Car : Vehicle
    {
        public int HowManyWheels { get; set; }
        public bool HeadlightStatus { get; set; }
    }
}
