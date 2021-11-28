using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Order
    {
        public int ID { set; get; }
        public DateTime Order_Date { set; get; }

        public int Quantity { set; get; }

        public string Delivery_Status { set; get; }

    }
}
