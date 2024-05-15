using Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Username).IsRequired().HasMaxLength(32);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.MiddleName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.HasMany(u => u.Roles).WithOne(ur => ur.User).HasForeignKey(ur => ur.UserId);
            builder.HasOne(u => u.Institute)
                .WithMany()
                .HasForeignKey(u => u.InstituteId);
            builder.Property(u => u.IsEnabled).IsRequired();

            builder.HasData(SeedDataRepo.GetUsers());
        }
    }
}
