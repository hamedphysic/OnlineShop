using OnlineShopApplication.Dtos.SaleAppDto.ProductAppDto;
using OnlineShopApplication.Services.Contracts;
using ResponseFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineShopApplication.Services.SaleServices
{
    public class ProductService : IProductService
   {
    //    private readonly Onlineshope.RepositoryDesignPttern.Frameworks.Abstracts.IRepository _Irepository;
        public ProductService()
        {
        }

        public Task<IResponse<object>> Delete(DeleteProductAppDto model)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<List<GetProductAppDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<object>> Post(PostProductAppDto model)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse<object>> Put(PutProductAppDto model)
        {
            throw new NotImplementedException();
        }
    }
}
