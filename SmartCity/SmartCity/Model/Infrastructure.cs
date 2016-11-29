using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class Infrastructure
    {
        public long IdInfrastructure { get; set; }
        public String Name { get; set; }
        public String InfraAddress { get; set; }
        public String InfraLocality { get; set; }
        public String InfraPostalCode { get; set; }
        public double GeolactionX { get; set; }
        public double GeolactionY { get; set; }
        public long IdTypeInfrastructure { get; set; }
    }
}
