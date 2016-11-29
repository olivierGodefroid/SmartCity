using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class TypeInfrastructure
    {
        public CategoryInfrastructure CategoryInfrastructure { get; set; }
        public long IdTypeInfrastructure { get; set; }
        public string Label { get; set; }
        public long IdCategoryInfrastructure { get; set; }
    }
}
