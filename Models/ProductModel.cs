using System;

namespace API.Models
{
  public class ProductModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Image { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastDateUpdate { get; set; }
    public int CategoryId { get; set; }
  }
}