using Onlineshop.EFCore;
using OnlineshopDmain.Aggregates.Sale;
using Onlineshope.RepositoryDesignPttern.Frameworks.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshope.RepositoryDesignPttern.Services.Sale
{
    public class ProductRepository : BaseRepository<OnlineshopDbContext, Product, Guid>
    {
        public ProductRepository(OnlineshopDbContext dbContext) : base(dbContext)
        {
        }
    }
}
