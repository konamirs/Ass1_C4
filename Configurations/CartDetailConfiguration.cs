using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C_sharf_4_Ass_1.Models;
namespace C_sharf_4_Ass_1.Configurations
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Cart).WithMany(p => p.CartDetails).
                HasForeignKey(x => x.UserId).HasConstraintName("FK_Cart");
            builder.HasOne(x => x.Product).WithMany(p => p.CartDetails).
                HasForeignKey(x => x.IdSp).HasConstraintName("FK_Product");
        }
    }
}
