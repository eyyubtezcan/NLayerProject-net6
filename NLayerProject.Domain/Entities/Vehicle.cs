using NLayerProject.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Description { get; set; } = "";
        public int Capacity { get; set; }
    
    }
}
