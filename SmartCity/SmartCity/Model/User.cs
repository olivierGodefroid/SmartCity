using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class User
    {
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
        public CurrentLocation CurrentLocation { get; set; }
    }
}
