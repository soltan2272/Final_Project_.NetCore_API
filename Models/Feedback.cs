﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public int CurrentUserID { get; set; }
        public User User { get; set; }
        public IList<ProductFeedback> productFeedbacks { get; set; }



    }
}
