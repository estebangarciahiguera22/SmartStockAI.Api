using Microsoft.AspNetCore.Mvc;
using SmartStockAI.Api.Models;
using SmartStockAI.Api.Services;

namespace SmartStockAI.Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var products = _productService.GetAll();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _productService.GetById(id);

        if (product is null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Create(ProductCreateRequest request)
    {
        var createdProduct = _productService.Create(request);

        return CreatedAtAction(
            nameof(GetById),
            new { id = createdProduct.Id },
            createdProduct
        );
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, ProductUpdateRequest request)
    {
        var updatedProduct = _productService.Update(id, request);

        if (updatedProduct is null)
        {
            return NotFound();
        }

        return Ok(updatedProduct);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = _productService.Delete(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}