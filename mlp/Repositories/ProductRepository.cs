using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mlp.Models;

namespace mlp.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(MlpContext context) : base(context)
        {

        }
    }
}
