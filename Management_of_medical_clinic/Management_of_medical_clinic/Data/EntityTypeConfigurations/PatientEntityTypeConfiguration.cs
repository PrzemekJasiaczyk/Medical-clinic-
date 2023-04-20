using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Console_Management_of_medical_clinic.Data.EntityTypeConfigurations
{
    public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<PatientModel>
    {
        public void Configure(EntityTypeBuilder<PatientModel> builder)
        {
            builder
                .ToTable("Patient");

            builder
                .HasKey(p => p.PatientId);

            #region Patient Properties Configuration

            builder
                .Property(p => p.PatientId)
                .IsRequired()
                .HasColumnName("IdPatient")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(60);

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasMaxLength(60);

            builder
                .Property(p => p.BirthDate)
                .IsRequired()
                .HasColumnName("DateOfBirth");

            builder
                .Property(p => p.PESEL)
                .IsRequired()
                .HasColumnName("PESEL")
                .HasMaxLength(11);

            builder
                .Property(p => p.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasConversion(new BoolToZeroOneConverter<short>());

            builder
                .Property(p => p.Sex)
                .IsRequired()
                .HasConversion(new EnumToNumberConverter<EnumSex, int>());

            builder
                .Property(p => p.LastVisitDate)
                .IsRequired(false)
                .HasColumnName("DateLastVisit");


            #endregion
        }

        public void Seed(EntityTypeBuilder<PatientModel> builder)
        {
            builder
                .HasData(
                    new PatientModel
                    {
                        PatientId = 1,
                        FirstName = "Juan Pablo",
                        LastName = "Rodriguez",
                        PESEL = "90010100191",
                        Sex = EnumSex.Male,
                        BirthDate = new DateTime(1990, 1, 1).Date,
                        IsActive = true
                    },
                    new PatientModel
                    {
                        PatientId = 2,
                        FirstName = "Janina",
                        LastName = "Pumpernikiel",
                        PESEL = "95020200222",
                        Sex = EnumSex.Female,
                        BirthDate = new DateTime(1995, 2, 2).Date,
                        IsActive = true
                    },
                    new Patient
                    {
                        PatientId = 3,
                        FirstName = "Aleksander I",
                        LastName = "Romanow",
                        PESEL = "70120300913",
                        Sex = EnumSex.Male,
                        BirthDate = new DateTime(1970, 12, 3).Date,
                        IsActive = true
                    },
                    new Patient
                    {
                        PatientId = 4,
                        FirstName = "Żaneta",
                        LastName = "Skowron-Ćwir",
                        PESEL = "50120300123",
                        Sex = EnumSex.Female,
                        BirthDate = new DateTime(1950, 12, 3).Date,
                        IsActive = true
                    },
                    new Patient
                    {
                        PatientId = 5,
                        FirstName = "Henryk",
                        LastName = "Walezy",
                        PESEL = "00320300213",
                        Sex = EnumSex.Male,
                        BirthDate = new DateTime(2000, 12, 3).Date,
                        IsActive= true
                    }
                );
        }
    }
}
