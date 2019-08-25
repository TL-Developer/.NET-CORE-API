using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Models;

namespace API.Controllers
{
  [Route("api/v1")]
  public class HomeController : Controller
  {

    [Route("products")]
    [HttpGet]
    public IEnumerable<ProductModel> ListProducts()
    {
      List<ProductModel> products = new List<ProductModel>();

      products.Add(new ProductModel{ Title = "Mouse" });

      return products;
    }
  }
}
