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
                { 1, new Product(1, "Rainbow Dash", "rainbowdash.jpg", "Leader", "This is my review", DateTime.Now, "I am a strong Pony! Haaaaay!") },
                { 2, new Product(2, "Fluttershy", "fluttershy.jpg", "Pony", "This is another review", DateTime.Now, "I am a shy Pony... hello!") },
                { 3, new Product(3, "Pinkie Pie", "pinkiepie.jpg", "Pony", "This is yet another review", DateTime.Now, "I am a fun Pony!!!") },
                { 4, new Product(4, "Twilight Sparkle", "twilightsparkle.jpg", "Pony", "This is yet yet another review", DateTime.Now, "I am yet another pony, heya!") },
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
