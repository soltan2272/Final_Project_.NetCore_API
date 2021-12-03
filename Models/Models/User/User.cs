using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class User: BaseModel
    {
        public string Full_Name { set; get; }
        public string Adrress { set; get; }
        public int Phone { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public int SSN { set; get; }
        public DateTime Date_Of_Birth { set; get; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public IList<AdminUser> AdminUsers { get; set; }



    }
}
