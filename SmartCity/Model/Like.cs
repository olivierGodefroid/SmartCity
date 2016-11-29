using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Like
    {
        public Like()
        {  }
        [Key]
        public long IdLike { get; set; }
        public int Score { get; set; }
        public long IdInfrastructure { get; set; }
        public long IdUse { get; set; }

        [ForeignKey("IdInfrastructure")]
        public virtual Infrastructure Infrastructure { get; set; }
        [ForeignKey("IdUse")]
        public virtual User User { get; set; }
    }
}
