﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User:IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        


        public ICollection<Post> Posts { get; set; } // Post sınıfı ile ilişki
    }
}
