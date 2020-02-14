using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mlp.Models;

namespace mlp.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public Dictionary<int, Product> productDictionary;

        public ProductRepository()
        {
            productDictionary = new Dictionary<int, Product>()
            {
                {1, new Product(1, "Rainbow Dash", "rainbowdash.png", "Leader", "This is my review", DateTime.Now, "I am a strong Pony! Haaaaay!");  }
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return productDictionary.Values;
        }
    }
}
