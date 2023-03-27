using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C_sharf_4_Ass_1.Models;

namespace C_sharf_4_Ass_1.Configurations
{
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).HasColumnType("int");
            builder.Property(p => p.Quantity).HasColumnType("int");
            builder.HasOne(x => x.Bill).WithMany(y => y.BillDetails).
                HasForeignKey(c => c.IDHD);
            builder.HasOne(x => x.Product).WithMany(y => y.BillDetails).
               HasForeignKey(c => c.IDHD);


        }
    }
}
