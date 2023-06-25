namespace WebApi.Services;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
}

public class ProductService : IProductService
{
    // users hardcoded for simplicity, store in a db with hashed passwords in production applications
    private List<Product> _products = new List<Product>
    {
        new Product { Code = 1001, Name = "sweet chocolate Ilis", Price = "27379.36", Quantity = "500", Rating =4 },
        new Product { Code = 1002, Name = "northern chocolate Dagmar", Price = "8810.24", Quantity = "500", Rating =5 },
        new Product { Code = 1002, Name = "arrogant tan Nelia",  Price = "4200.08", Quantity = "400", Rating =2 }
    };

    private readonly AppSettings _appSettings;

    public ProductService(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }   

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public Product GetById(int id)
    {
        return _products.FirstOrDefault(x => x.Code == id);
    }  

}