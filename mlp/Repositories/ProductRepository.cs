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
                { 0, new Product(0, "Rainbow Dash", "rainbowdash.png", "Leader", DateTime.Now, "I am a strong Pony! Haaaaay!") },
                { 1, new Product(1, "Fluttershy", "fluttershy.png", "Pony", DateTime.Now, "I am a shy Pony... hello!") },
                { 2, new Product(2, "Pinkie Pie", "pinkypie.png", "Pony", DateTime.Now, "I am a fun Pony!!!") },
                { 3, new Product(3, "Twilight Sparkle", "twilightsparkle.png", "Pony", DateTime.Now, "I am yet another pony, heya!") },
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return productDictionary.Values;
        }

        public Product GetById(int id)
        {
            
            return productDictionary[id];
        }

    }
}
