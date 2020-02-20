using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mlp.Models;

namespace mlp.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private MlpContext db;

        public ProductRepository(MlpContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public Product GetById(int id)
        {
            
            return db.Products.Find(id);
        }

    }
}
