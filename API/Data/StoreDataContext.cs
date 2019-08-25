using Microsoft.EntityFrameworkCore;
using API.Models;
using API.Data.Maps;

namespace API
{
  public class StoreDataContext : DbContext
  {
    public DbSet<ProductModel> ProductsData { get; set; }
    public DbSet<CategoryModel> CategoriesData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // TODO => Get the connection string from Azure(Dynamic)
      //optionsBuilder.UseSqlServer(@"Server=localhost,1443,Database=prodcat;User ID=SA;Password=semsenha@123");
      optionsBuilder.UseInMemoryDatabase();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfiguration(new ProductMap());
    }
  }
}
