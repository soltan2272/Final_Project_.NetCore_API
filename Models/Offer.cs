using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Offer
    {
        public int ID { get; set; }
        public DateTime Start_Date {get; set;}
        public DateTime End_Date { get; set; }
        public float Discount_Percentage { get; set; }
        public float Current_Price { get; set; }

    }
}
