using System.Collections.Generic;
using API.Models;
using API.Data;

namespace API.Repositories
{
  public class ProductRepository
  {
    private readonly StoreDataContext _context;

    public ProductRepository(StoreDataContext context)
    {
      _context = context;
    }

    public IEnumerable<ProductModel> GetListProducts()
    {
      //List<ProductModel> listProducts = new List<ProductModel>();
      //listProducts.Add(new ProductModel { Title = "Mouse" });
      return _context.ProductsData;
    }

    public void CreateProduct(ProductModel product)
    {
      _context.ProductsData.Add(product);
      _context.SaveChanges();
    }
  }
}
