﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? name { get; set; }

        public ICollection<Post> Posts { get; set; } // Post sınıfı ile ilişki
    }
}
