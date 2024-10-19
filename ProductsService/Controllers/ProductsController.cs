using Microsoft.AspNetCore.Mvc;
using ProductsService.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Product A", Price = 10.00M },
        new Product { Id = 2, Name = "Product B", Price = 15.00M }
    };

    [HttpGet]
    public ActionResult<List<Product>> GetProducts() => Products;

    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = Products.Find(p => p.Id == id);
        if (product == null) return NotFound();
        return product;
    }
}
