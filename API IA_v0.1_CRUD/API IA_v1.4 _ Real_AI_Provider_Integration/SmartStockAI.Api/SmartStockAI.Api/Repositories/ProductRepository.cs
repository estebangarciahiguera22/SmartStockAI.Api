using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();
    private int _nextId = 1;

    public List<Product> GetAll()
    {
        return _products;
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(product => product.Id == id);
    }

    public Product Create(Product product)
    {
        product.Id = _nextId++;
        _products.Add(product);
        return product;
    }

    public Product? Update(int id, Product product)
    {
        var existingProduct = GetById(id);

        if (existingProduct is null)
        {
            return null;
        }

        existingProduct.Name = product.Name;
        existingProduct.Category = product.Category;
        existingProduct.Material = product.Material;
        existingProduct.Stone = product.Stone;
        existingProduct.Collection = product.Collection;
        existingProduct.Style = product.Style;
        existingProduct.Stock = product.Stock;
        existingProduct.MinimumStock = product.MinimumStock;
        existingProduct.Price = product.Price;
        existingProduct.Currency = product.Currency;
        existingProduct.TargetMarket = product.TargetMarket;


        return existingProduct;
    }

    public bool Delete(int id)
    {
        var existingProduct = GetById(id);

        if (existingProduct is null)
        {
            return false;
        }

        _products.Remove(existingProduct);
        return true;
    }
}