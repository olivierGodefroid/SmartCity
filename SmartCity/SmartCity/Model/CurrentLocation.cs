using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class CurrentLocation
    {
        public long IdCurrentLocation { get; set; }
        public DateTime Date { get; set; }
        public long IdUser { get; set; }
        public long IdInfrastructure { get; set; }
        public virtual User User { get; set; }
        public virtual Infrastructure Infrastructure { get; set; }
    }
}
