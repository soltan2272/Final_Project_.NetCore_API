using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
<<<<<<< HEAD
    public class Contact: BaseModel
=======
<<<<<<< HEAD
  public class Contact
=======
    public class Contact
>>>>>>> ae2378734f8de29dab33be5d4231f0f3544effe9
>>>>>>> ba09747b3ffc997a6d3fd61f0afcfcd83e29ab15
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public ICollection<Admin> Admins { get; set; }

    }
}
