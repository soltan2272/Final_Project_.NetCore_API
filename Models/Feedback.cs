﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feedback
    {
        public int FID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }

    }
}