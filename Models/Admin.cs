using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin: BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { set; get; }
<<<<<<< HEAD
=======
        public int CurrentContactID { get; set; }
        public Contact Contact { get; set; }
        public IList<AdminUser> AdminUsers { get; set; }
        public IList<AdminProduct> AdminProducts { get; set; }
        public IList<AdminStore> AdminStores { get; set; }
<<<<<<< HEAD
>>>>>>> d6e0b85c95a90919ccb9039a53ed974b4576d60d
=======
        public IList<AdminSupplier> AdminSuppliers { get; set; }

>>>>>>> c7da0d702047c975520ecdf99d5a8d273669a669


    }
}
