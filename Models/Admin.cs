﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { set; get; }
        public IList<AdminSupplier> AdminSuppliers { get; set; }


    }
}
