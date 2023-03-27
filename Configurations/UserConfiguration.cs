using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using C_sharf_4_Ass_1.Models;
namespace C_sharf_4_Ass_1.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.UserId);
            builder.Property(p => p.Username).HasColumnType("nchar(256)");
            builder.Property(p => p.Status).HasColumnType(("int")).IsRequired();
            builder.Property(p => p.Password).HasColumnType("nchar(256)");
            builder.HasOne(p=>p.Role).WithMany(c=>c.Users).
                HasForeignKey(x=>x.RoleId);
        }
    }
}
