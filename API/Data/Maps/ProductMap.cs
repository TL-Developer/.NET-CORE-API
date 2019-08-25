using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API.Models;

namespace API.Data.Maps
{
  public class ProductMap : IEntityTypeConfiguration<ProductModel>
  {
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
      builder.ToTable("Product");
      builder.HasKey(product => product.Id);
      builder.Property(product => product.Description).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
      builder.Property(product => product.Price).IsRequired().HasColumnType("money");
      builder.Property(product => product.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
    }
  }
}
