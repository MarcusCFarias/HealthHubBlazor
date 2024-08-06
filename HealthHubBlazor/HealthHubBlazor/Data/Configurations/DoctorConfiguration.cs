using HealthHubBlazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthHubBlazor.Data.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctors");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(d => d.Document)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(d => d.CRM)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(d => d.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(d => d.Specialty)
                .WithMany(s => s.Doctors)
                .HasForeignKey(d => d.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.Meetings)
                .WithOne(m => m.Doctor)
                .HasForeignKey(m => m.DoctorId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
