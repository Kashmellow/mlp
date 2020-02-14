using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mlp.Models;

namespace mlp.Repositories
{
    public class ProductRepository : IRepository<Product>
    {


        public IEnumerable<Product> GetAll()
        {
            return productDictionary.Values;
        }
    }
}
