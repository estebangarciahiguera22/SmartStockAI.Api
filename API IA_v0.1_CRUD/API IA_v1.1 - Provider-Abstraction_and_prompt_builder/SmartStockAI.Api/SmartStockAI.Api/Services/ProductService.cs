using SmartStockAI.Api.Models;
using SmartStockAI.Api.Repositories;

namespace SmartStockAI.Api.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<ProductResponse> GetAll()
    {
        return _productRepository.GetAll()
            .Select(product => ToResponse(product))
            .ToList();
    }

    public ProductResponse? GetById(int id)
    {
        var product = _productRepository.GetById(id);

        if (product is null)
        {
            return null;
        }

        return ToResponse(product);
    }

    public ProductResponse Create(ProductCreateRequest request)
    {
        var product = new Product
        {
            Name = request.Name,
            Category = request.Category,
            Material = request.Material,
            Stone = request.Stone,
            Collection = request.Collection,
            Style = request.Style,
            Stock = request.Stock,
            MinimumStock = request.MinimumStock,
            Price = request.Price,
            Currency = request.Currency,
            TargetMarket = request.TargetMarket
        };

        var createdProduct = _productRepository.Create(product);

        return ToResponse(createdProduct);
    }

    public ProductResponse? Update(int id, ProductUpdateRequest request)
    {
        var product = new Product
        {
            Name = request.Name,
            Category = request.Category,
            Material = request.Material,
            Stone = request.Stone,
            Collection = request.Collection,
            Style = request.Style,
            Stock = request.Stock,
            MinimumStock = request.MinimumStock,
            Price = request.Price,
            Currency = request.Currency,
            TargetMarket = request.TargetMarket
        };

        var updatedProduct = _productRepository.Update(id, product);

        if (updatedProduct is null)
        {
            return null;
        }

        return ToResponse(updatedProduct);
    }

    public bool Delete(int id)
    {
        return _productRepository.Delete(id);
    }

    private static ProductResponse ToResponse(Product product)
    {
        return new ProductResponse
        {
            Id = product.Id,
            Name = product.Name,
            Category = product.Category,
            Material = product.Material,
            Stone = product.Stone,
            Collection = product.Collection,
            Style = product.Style,
            Stock = product.Stock,
            MinimumStock = product.MinimumStock,
            Price = product.Price,
            Currency = product.Currency,
            TargetMarket = product.TargetMarket
        };
    }
}