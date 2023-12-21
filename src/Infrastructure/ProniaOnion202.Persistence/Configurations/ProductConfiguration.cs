using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProniaOnion202.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Persistence.Configurations
{
	internal class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.Property(x => x.Name).IsRequired();
			builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
			builder.Property(c => c.Price).IsRequired().HasColumnType("decimal(6,2)");
			builder.Property(p => p.Description).IsRequired().HasColumnType("text");
			builder.Property(p => p.SKU).IsRequired().HasMaxLength(100);
		}
	}
}
