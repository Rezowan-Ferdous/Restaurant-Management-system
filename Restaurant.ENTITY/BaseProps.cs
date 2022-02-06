﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class BaseProps
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
