using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TypeInfrastructure
    {
        public TypeInfrastructure()
        { }
        [Key]
        public long IdTypeInfrastructure { get; set; }
        public String Label { get; set; }
        public long IdCategoryInfrastructure { get; set; }

        [ForeignKey("IdCategoryInfrastructure")]
        public virtual CategoryInfrastructure CategoryInfrastructure { get; set; }
    }
}
