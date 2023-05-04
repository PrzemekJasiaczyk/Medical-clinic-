using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Console_Management_of_medical_clinic.Data.EntityTypeConfigurations
{
    // TODO: Follow changes in Visit class
    public class VisitEntityTypeConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder
                .ToTable("Visit");

            builder
                .HasKey(v => v.VisitId);

            builder
                .HasOne(v => v.Patient)
                .WithMany(p => p.Visits)
                .HasForeignKey(v => v.PatientId);

            builder
                .HasOne(v => v.Employee)
                .WithMany(p => p.Visits)
                .HasForeignKey(v => v.PatientId);


            #region Visit Properties Configuration

            builder
                .Property(v => v.VisitId)
                .IsRequired()
                .HasColumnName("IdVisit")
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.PatientId)
                .HasColumnName("IdPatient");

            builder
                .Property(v => v.EmployeeId)
                .HasColumnName("IdEmployee");

            builder
                .Property(v => v.VisitDate)
                .IsRequired()
                .HasColumnName("DateVisit");

            builder
                .Property(v => v.VisitHour)
                .IsRequired()
                .HasColumnName("HourVisit");

            builder
                .Property(v => v.Cost)
                .IsRequired()
                .HasColumnName("CostVisit");

            #endregion
        }
    }
}
