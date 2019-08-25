using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Repositories;

namespace API.Controllers
{
  [Route("api/v1")]
  public class ProductController : Controller
  {
    private readonly ProductRepository _repository;

    public ProductController(ProductRepository repository)
    {
      _repository = repository;
    }

    [Route("products")]
    [HttpGet]
    public IEnumerable<ProductModel> GetListProducts()
    {
      return _repository.GetListProducts();
    }

    [Route("products")]
    [HttpPost]
    public string PostProduct([FromBody]ProductModel product)
    {
      _repository.CreateProduct(product);
      return "Product saved!";
    }
  }
}
