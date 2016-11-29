using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class User
    {

        public User()
        { }

        [Key]
        public long IdUser { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserAdress { get; set; }
        public String UserLocality { get; set; }
        public String UserPostalCode { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Phone { get; set; }
        public Boolean isMale { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<User> Friends { get; set; }
        public CurrentLocation CurrentLocation { get; set; }

    }
}
