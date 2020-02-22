using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Public;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public PagedResults<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
