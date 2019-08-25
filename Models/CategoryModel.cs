using System;
using System.Collections.Generic;

namespace API.Models
{
  public class CategoryModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public IEnumerable<ProductModel> Products { get; set; }
  }
}
