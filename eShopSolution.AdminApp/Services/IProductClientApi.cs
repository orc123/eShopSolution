using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface IProductClientApi
    {
        Task<ApiResult<PagedResults<ProductVm>>> GetProductPaging(GetManageProductPagingRequest request);
    }
}
