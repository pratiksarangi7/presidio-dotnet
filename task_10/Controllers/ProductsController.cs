using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;

namespace ProductService.Controllers;

[ApiController]
[Route("api/[controller]")] // Routes to /api/products
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(IProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService;
        _logger = logger;
    }

    /// <summary>
    /// Retreives list of prods in db.
    /// </summary>
    /// <returns>A list of products</returns>
    /// <response code="200">Returns the list of products successfully</response>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
    public async Task<IActionResult> GetAll()
    {
        _logger.LogInformation("Fetching all products...");
        var products = await _productService.GetAllAsync();
        return Ok(products); // Returns 200 OK
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        var createdProduct = await _productService.CreateAsync(product);
        _logger.LogInformation($"Created product with ID: {createdProduct.Id}");

        // Returns 201 Created, and a link to get the newly created resource
        return CreatedAtAction(nameof(GetAll), new { id = createdProduct.Id }, createdProduct);
    }
}