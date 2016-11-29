using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Infrastructure
    {
        public Infrastructure()
        {}

        [Key]
        public long IdInfrastructure { get; set; }
        public String Name { get; set; }
        public String InfraAddress { get; set; }
        public String InfraLocality { get; set; }
        public String InfraPostalCode { get; set; }
        public double GeolactionX { get; set; }
        public double GeolactionY { get; set; }
        public long IdTypeInfrastructure { get; set; }
        [ForeignKey("IdTypeInfrastructure")]
        public virtual TypeInfrastructure TypeInfrastructure { get; set; }
    }
}
