﻿// <auto-generated />
using System;
using Console_Management_of_medical_clinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Console_Management_of_medical_clinic.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.AppointmentModel", b =>
                {
                    b.Property<int>("IdAppointment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdCalendar")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDay")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IdEmployee")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IdOffice")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTerm")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdAppointment");

                    b.HasIndex("IdCalendar");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("IdOffice");

                    b.HasIndex("PatientId");

                    b.ToTable("DbAppointments");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.CalendarModel", b =>
                {
                    b.Property<int>("IdCalendar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateReference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdCalendar");

                    b.ToTable("DbCalendars");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.DoctorsDayPlanModel", b =>
                {
                    b.Property<int>("IdDoctorsDayPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdCalendar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDay")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IdEmployee")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdOfTerm")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IdOffice")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDoctorsDayPlan");

                    b.HasIndex("IdCalendar");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("IdOffice");

                    b.HasIndex("PatientId");

                    b.ToTable("DbDoctorsDayPlan");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.EmployeeModel", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CorrespondenceAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdSpecialization")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sex")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdEmployee");

                    b.HasIndex("IdSpecialization");

                    b.ToTable("DbEmployees");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.OfficeModel", b =>
                {
                    b.Property<int>("IdOffice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSpecialization")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdOffice");

                    b.HasIndex("IdSpecialization");

                    b.ToTable("DbOffices");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("IdPatient");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<short>("IsActive")
                        .HasColumnType("INTEGER")
                        .HasColumnName("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("LastName");

                    b.Property<DateTime?>("LastVisitDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("DateLastVisit");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT")
                        .HasColumnName("PESEL");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.HasKey("PatientId");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Juan Pablo",
                            IsActive = (short)1,
                            LastName = "Rodriguez",
                            PESEL = "90010100191",
                            Sex = 1
                        },
                        new
                        {
                            PatientId = 2,
                            BirthDate = new DateTime(1995, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Janina",
                            IsActive = (short)1,
                            LastName = "Pumpernikiel",
                            PESEL = "95020200222",
                            Sex = 2
                        },
                        new
                        {
                            PatientId = 3,
                            BirthDate = new DateTime(1970, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Aleksander I",
                            IsActive = (short)1,
                            LastName = "Romanow",
                            PESEL = "70120300913",
                            Sex = 1
                        },
                        new
                        {
                            PatientId = 4,
                            BirthDate = new DateTime(1950, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Żaneta",
                            IsActive = (short)1,
                            LastName = "Skowron-Ćwir",
                            PESEL = "50120300123",
                            Sex = 2
                        },
                        new
                        {
                            PatientId = 5,
                            BirthDate = new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Henryk",
                            IsActive = (short)1,
                            LastName = "Walezy",
                            PESEL = "00320300213",
                            Sex = 1
                        });
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.SpecializationModel", b =>
                {
                    b.Property<int>("IdSpecialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSpecialization");

                    b.ToTable("DbSpecializations");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.UserModel", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdUser");

                    b.HasIndex("IdEmployee")
                        .IsUnique();

                    b.ToTable("DbUsers");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("IdVisit");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT")
                        .HasColumnName("CostVisit");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("IdEmployee");

                    b.Property<int?>("PatientId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("IdPatient");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("DateVisit");

                    b.Property<DateTime>("VisitHour")
                        .HasColumnType("TEXT")
                        .HasColumnName("HourVisit");

                    b.HasKey("VisitId");

                    b.HasIndex("PatientId");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.AppointmentModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.CalendarModel", "CalendarModel")
                        .WithMany()
                        .HasForeignKey("IdCalendar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console_Management_of_medical_clinic.Model.EmployeeModel", "EmployeeModel")
                        .WithMany()
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console_Management_of_medical_clinic.Model.OfficeModel", "OfficeModel")
                        .WithMany()
                        .HasForeignKey("IdOffice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console_Management_of_medical_clinic.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("CalendarModel");

                    b.Navigation("EmployeeModel");

                    b.Navigation("OfficeModel");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.DoctorsDayPlanModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.CalendarModel", "CalendarModel")
                        .WithMany("DoctorsDayPlanModels")
                        .HasForeignKey("IdCalendar");

                    b.HasOne("Console_Management_of_medical_clinic.Model.EmployeeModel", "EmployeeModel")
                        .WithMany()
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console_Management_of_medical_clinic.Model.OfficeModel", "OfficeModel")
                        .WithMany()
                        .HasForeignKey("IdOffice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Console_Management_of_medical_clinic.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("CalendarModel");

                    b.Navigation("EmployeeModel");

                    b.Navigation("OfficeModel");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.EmployeeModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.SpecializationModel", "SpecializationModel")
                        .WithMany("EmployeeModels")
                        .HasForeignKey("IdSpecialization");

                    b.Navigation("SpecializationModel");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.OfficeModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.SpecializationModel", "SpecializationModel")
                        .WithMany()
                        .HasForeignKey("IdSpecialization")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecializationModel");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.UserModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.EmployeeModel", "EmployeeModel")
                        .WithOne("UserModel")
                        .HasForeignKey("Console_Management_of_medical_clinic.Model.UserModel", "IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeModel");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.Visit", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.EmployeeModel", "Employee")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId");

                    b.HasOne("Console_Management_of_medical_clinic.Model.Patient", "Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientId");

                    b.Navigation("Employee");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.CalendarModel", b =>
                {
                    b.Navigation("DoctorsDayPlanModels");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.EmployeeModel", b =>
                {
                    b.Navigation("UserModel");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.Patient", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.SpecializationModel", b =>
                {
                    b.Navigation("EmployeeModels");
                });
#pragma warning restore 612, 618
        }
    }
}
