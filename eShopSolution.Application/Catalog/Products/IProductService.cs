using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Dtos;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task UpdateViewCount(int productId);

        Task<int> Delete(int productId);

        Task<ProductVm> GetById(int productId, string languegeId);

        Task<ApiResult<PagedResults<ProductVm>>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResults<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}