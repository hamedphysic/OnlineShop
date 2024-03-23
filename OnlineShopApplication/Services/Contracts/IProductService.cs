using OnlineShopApplication.Dtos.SaleAppDto.ProductAppDto;
using ResponseFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopApplication.Services.Contracts
{
    public interface IProductService
    {
        Task<IResponse<object>> Post(PostProductAppDto model);
        Task<IResponse<object>> Put(PutProductAppDto model);
        Task<IResponse<object>> Delete(DeleteProductAppDto model);
        Task<IResponse<List<GetProductAppDto>>> GetAll();

    }
}
