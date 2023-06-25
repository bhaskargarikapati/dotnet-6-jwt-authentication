namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _productService.GetAll();
        return Ok(users);
    }

    [AllowAnonymous]
    [HttpGet("{id:int}")]
    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }
}
