using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mlp.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string Content { get; set; }
        public string ReviewerName { get; set; }
        public double Rating { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public Review()
        {

        }
    }
}
