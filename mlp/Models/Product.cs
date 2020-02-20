using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mlp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public DateTime DateTimeGroup { get; set; }
        public string Description { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string image, string category, DateTime dateTimeGroup, string description)
        {
            ProductId = id;
            Name = name;
            Image = image;
            Category = category;
            DateTimeGroup = dateTimeGroup;
            Description = description;
        }
    }
}
