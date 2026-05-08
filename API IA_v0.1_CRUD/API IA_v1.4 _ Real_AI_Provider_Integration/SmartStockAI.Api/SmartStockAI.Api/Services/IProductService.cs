using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Services;

public interface IProductService
{
    List<ProductResponse> GetAll();

    ProductResponse? GetById(int id);

    ProductResponse Create(ProductCreateRequest request);

    ProductResponse? Update(int id, ProductUpdateRequest request);

    bool Delete(int id);
}