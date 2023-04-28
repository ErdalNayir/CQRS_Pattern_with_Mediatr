using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post
    {   
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Likes { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

 
    }
}
