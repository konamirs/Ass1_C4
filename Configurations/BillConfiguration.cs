using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C_sharf_4_Ass_1.Models;

namespace C_sharf_4_Ass_1.Configurations

{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.CreateDate).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.Status).HasColumnType("nvarchar(1000)").
                IsRequired(); 
        }
    }
}
