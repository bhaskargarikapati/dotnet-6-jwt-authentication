namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Product
{
    public int Code { get; set; }
    public string Name { get; set; }  
    public string Price { get; set; }

    public int Rating { get; set; }
    public string Quantity { get; set; }

    
}