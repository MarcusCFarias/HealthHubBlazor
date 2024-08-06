using HealthHubBlazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthHubBlazor.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Description).IsRequired();
            builder.Property(m => m.MeetingDate).IsRequired();
            builder.Property(m => m.CreationDate).IsRequired();
            builder.HasOne(m => m.Doctor).WithMany(d => d.Meetings).HasForeignKey(m => m.DoctorId);
            builder.HasOne(m => m.Patient).WithMany(p => p.Meetings).HasForeignKey(m => m.PatientId);
            
        }
    }
}
