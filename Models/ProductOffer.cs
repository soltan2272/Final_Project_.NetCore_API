﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ProductOffer
    {
        public int Product_ID { set; get; }
        public Product product { set; get; }

        public int Offer_ID { set; get; }
        public Offer offer { set; get; }
    }
}
