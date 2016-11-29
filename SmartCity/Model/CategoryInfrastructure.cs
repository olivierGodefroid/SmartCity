using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryInfrastructure
    {
        public CategoryInfrastructure(){}

        [Key]
        public long IdCategoryInfrastructure { get; set; }
        public String Label { get; set; }

    }
}
