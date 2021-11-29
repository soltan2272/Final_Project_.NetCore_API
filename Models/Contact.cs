using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public ICollection<Admin> Admins { get; set; }

    }
}
