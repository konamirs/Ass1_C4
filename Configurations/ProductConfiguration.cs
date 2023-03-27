using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C_sharf_4_Ass_1.Models;
namespace C_sharf_4_Ass_1.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
          builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Description).IsUnicode(true).
                HasMaxLength(100).IsFixedLength();
            builder.Property(p => p.Supplier).HasColumnType("nvarchar(100)");
        }
    }
}
