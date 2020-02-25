using mlp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mlp.Repositories
{
    public class ReviewRepository : Repository<Review>
    {
        public ReviewRepository(MlpContext context) : base(context)
        {

        }
    }
}
