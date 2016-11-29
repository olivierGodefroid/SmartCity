using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CurrentLocation
    {
        public CurrentLocation()
        { }

        [Key]
        public long IdCurrentLocation { get; set; }
        public DateTime Date { get; set; }
        public long IdUser { get; set; }
        public long IdInfrastructure { get; set; }


        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        [ForeignKey("IdInfrastructure")]
        public virtual Infrastructure Infrastructure { get; set; }
    }
}
