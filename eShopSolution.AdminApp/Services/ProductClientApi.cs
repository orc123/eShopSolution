using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public class ProductClientApi : BaseApiClient, IProductClientApi
    {
        public ProductClientApi(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<ApiResult<PagedResults<ProductVm>>> GetProductPaging(GetManageProductPagingRequest request)
        {
            return await base.GetAsync<ApiResult<PagedResults<ProductVm>>>(
                $"/api/products/paging?pageIndex={request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}&languageId={request.LanguageId}");
        }
    }
}
