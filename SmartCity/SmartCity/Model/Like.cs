using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class Like
    {
        public long IdLike { get; set; }
        public int Score { get; set; }
        public long IdInfrastructure { get; set; }
        public long IdUse { get; set; }
        public virtual Infrastructure Infrastructure { get; set; }
        public virtual User User { get; set; }
    }
}
