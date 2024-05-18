using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MS.Data.Entities;
using MS.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Enums;

namespace MS.Infrastructure.Contexts
{
    public class Context: IdentityDbContext<ApplicationUser>
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seeding Data
              modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "1",
                    FirstName = "Mohamed",
                    LastName = "Ali",
                    NID = "2636523632",
                    Gender = "Male",
                    IsRegister = true,
                    BirthDate = new DateTime(2002, 9, 25),
                    UserName = "MohamedAli123",
                    NormalizedEmail = "MOHAMED@EXAMPLE.COM",
                    NormalizedUserName = "MOHAMEDALI123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "O+",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "2",
                    FirstName = "Mona",
                    LastName = "Omar",
                    NID = "5312523632",
                    Gender = "Female",
                    IsRegister = true,
                    BirthDate = new DateTime(2012, 6, 25),
                    UserName = "monaomar123",
                    NormalizedEmail = "MONA@EXAMPLE.COM",
                    NormalizedUserName = "MONAOMAR123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "A+",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "3",
                    FirstName = "Mohammed",
                    LastName = "Ali",
                    NID = "9876543210",
                    Gender = "Male",
                    IsRegister = true,
                    BirthDate = new DateTime(1988, 10, 5),
                    UserName = "MOHAMMED123",
                    NormalizedEmail = "MOHAMMED@EXAMPLE.COM",
                    NormalizedUserName = "MOHAMMED123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "B+",
                    MaritalStatus = "Married"
                },
                new ApplicationUser
                {
                    Id = "4",
                    FirstName = "Aisha",
                    LastName = "Ali",
                    NID = "0123456789",
                    Gender = "Female",
                    IsRegister = true,
                    BirthDate = new DateTime(1995, 3, 25),
                    UserName = "AISHA321",
                    NormalizedEmail = "AISHA@EXAMPLE.COM",
                    NormalizedUserName = "AISHA321",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "AB+",
                    MaritalStatus = "Married"
                },
                new ApplicationUser
                {
                    Id = "5",
                    FirstName = "Ahmad",
                    LastName = "Ali",
                    NID = "1122334455",
                    Gender = "Male",
                    IsRegister = true,
                    BirthDate = new DateTime(1978, 3, 10),
                    UserName = "AHMAD567",
                    NormalizedEmail = "AHMAD@EXAMPLE.COM",
                    NormalizedUserName = "AHMAD567",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "O-",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "6",
                    FirstName = "Aya",
                    LastName = "Ali",
                    NID = "3344556677",
                    Gender = "Female",
                    IsRegister = true,
                    BirthDate = new DateTime(1989, 7, 5),
                    UserName = "AYA789",
                    NormalizedEmail = "AYA@EXAMPLE.COM",
                    NormalizedUserName = "AYA789",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "A-",
                    MaritalStatus = "Married"
                },
                new ApplicationUser
                {
                    Id = "7",
                    FirstName = "Omar",
                    LastName = "Ali",
                    NID = "5544332211",
                    Gender = "Male",
                    IsRegister = true,
                    BirthDate = new DateTime(1995, 12, 12),
                    UserName = "OMAR101",
                    NormalizedEmail = "OMAR@EXAMPLE.COM",
                    NormalizedUserName = "OMAR101",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "B-",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "8",
                    FirstName = "Sara",
                    LastName = "Ali",
                    NID = "7788990011",
                    Gender = "Female",
                    IsRegister = true,
                    BirthDate = new DateTime(1980, 1, 30),
                    UserName = "SARA2022",
                    NormalizedEmail = "SARA@EXAMPLE.COM",
                    NormalizedUserName = "SARA2022",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "AB-",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "9",
                    FirstName = "Ali",
                    LastName = "Ali",
                    NID = "6677889900",
                    Gender = "Male",
                    IsRegister = true,
                    BirthDate = new DateTime(1998, 5, 20),
                    UserName = "ALI3030",
                    NormalizedEmail = "ALI@EXAMPLE.COM",
                    NormalizedUserName = "ALI3030",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "O+",
                    MaritalStatus = "Single"
                },
                new ApplicationUser
                {
                    Id = "10",
                    FirstName = "Laila",
                    LastName = "Ali",
                    NID = "1122334455",
                    Gender = "Female",
                    IsRegister = true,
                    BirthDate = new DateTime(1982, 10, 10),
                    UserName = "LAILA4040",
                    NormalizedEmail = "LAILA@EXAMPLE.COM",
                    NormalizedUserName = "LAILA4040",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    BloodType = "A+",
                    MaritalStatus = "Married"
                });

            modelBuilder.Entity<Clinic>().HasData(
              new Clinic
              {
                  ID = 1,
                  Name = "Elzahraa",
                  DepartmentID = 1,
                  Description = "",
                  PhotoID = 1,
                  WorkDays = new List<WeekDays> { WeekDays.Sunday, WeekDays.Monday, WeekDays.Wednesday, WeekDays.Friday }
              },
              new Clinic
              {
                  ID = 2,
                  Name = "Alpha",
                  DepartmentID = 2,
                  Description = "",
                  PhotoID = 2,
                  WorkDays = new List<WeekDays> { WeekDays.Monday, WeekDays.Tuesday, WeekDays.Thursday }
              },
              new Clinic
              {
                  ID = 3,
                  DepartmentID = 3,
                  Name = "Mediplus",
                  Description = "",
                  PhotoID = 3,
                  WorkDays = new List<WeekDays> { WeekDays.Tuesday, WeekDays.Wednesday, WeekDays.Thursday, WeekDays.Saturday }
              },
              new Clinic
              {
                  ID = 4,
                  DepartmentID = 4,
                  Name = "Elzahraa",
                  Description = "",
                  PhotoID = 4,
                  WorkDays = new List<WeekDays> { WeekDays.Sunday, WeekDays.Monday, WeekDays.Friday }
              },
              new Clinic
              {
                  ID = 5,
                  DepartmentID = 5,
                  Name = "Alpha",
                  Description = "",
                  PhotoID = 5,
                  WorkDays = new List<WeekDays> { WeekDays.Monday, WeekDays.Tuesday, WeekDays.Wednesday, WeekDays.Thursday }
              },
              new Clinic
              {
                  ID = 6,
                  DepartmentID = 6,
                  Name = "Mediplus",
                  Description = "",
                  PhotoID = 6,
                  WorkDays = new List<WeekDays> { WeekDays.Tuesday, WeekDays.Wednesday, WeekDays.Friday }
              },
              new Clinic
              {
                  ID = 7,
                  DepartmentID = 7,
                  Name = "Elzahraa",
                  Description = "",
                  PhotoID = 7,
                  WorkDays = new List<WeekDays> { WeekDays.Sunday, WeekDays.Tuesday, WeekDays.Thursday }
              },
              new Clinic
              {
                  ID = 8,
                  DepartmentID = 8,
                  Name = "Alpha",
                  Description = "",
                  PhotoID = 8,
                  WorkDays = new List<WeekDays> { WeekDays.Monday, WeekDays.Wednesday, WeekDays.Friday }
              },
              new Clinic
              {
                  ID = 9,
                  DepartmentID = 9,
                  Name = "Mediplus",
                  Description = "",
                  PhotoID = 9,
                  WorkDays = new List<WeekDays> { WeekDays.Tuesday, WeekDays.Thursday, WeekDays.Saturday }
              },
              new Clinic
              {
                  ID = 10,
                  DepartmentID = 10,
                  Name = "Elzahraa",
                  Description = "",
                  PhotoID = 10,
                  WorkDays = new List<WeekDays> { WeekDays.Sunday, WeekDays.Monday, WeekDays.Wednesday, WeekDays.Friday }
              });

            modelBuilder.Entity<PlacePrice>().HasData(
                new PlacePrice
                {
                    ID = 1,
                    Name = "X-Alpha",
                    Price = 341.40,
                    PlaceID = 2,
                    PlaceType = PlaceType.Lab

                },
                new PlacePrice
                {
                    ID = 2,
                    Name = "X-Beta",
                    PlaceID = 3,
                    PlaceType = PlaceType.Pharmacy,
                    Price = 419.99
                },
                new PlacePrice
                {
                    ID = 3,
                    Name = "X-ray",
                    Price = 260.40,
                    PlaceID = 1,
                    PlaceType = PlaceType.Lab

                },
                new PlacePrice
                {
                    ID = 4,
                    Name = "MRI",
                    PlaceID = 4,
                    PlaceType = PlaceType.Lab,
                    Price = 599.99
                },
                new PlacePrice
                {
                    ID = 5,
                    Name = "Ultrasound",
                    PlaceID = 5,
                    PlaceType = PlaceType.Lab,
                    Price = 199.99
                },
                new PlacePrice
                {
                    ID = 6,
                    Name = "CT Scan",
                    PlaceID = 6,
                    PlaceType = PlaceType.Lab,
                    Price = 399.99
                },
                new PlacePrice
                {
                    ID = 7,
                    Name = "PET Scan",
                    PlaceID = 7,
                    PlaceType = PlaceType.Lab,
                    Price = 1199.99
                },
                new PlacePrice
                {
                    ID = 8,
                    Name = "Mammography",
                    PlaceID = 8,
                    PlaceType = PlaceType.Lab,
                    Price = 199.99
                },
                new PlacePrice
                {
                    ID = 9,
                    Name = "Fluoroscopy",
                    PlaceID = 9,
                    PlaceType = PlaceType.Lab,
                    Price = 699.99
                },
                new PlacePrice
                {
                    ID = 10,
                    Name = "DEXA Scan",
                    PlaceID = 10,
                    PlaceType = PlaceType.Pharmacy,
                    Price = 249.99
                });

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    ID = 1,
                    Name = "Cardiology",
                    HospitalID = 1 // Assuming hospital ID is 1
                },
                new Department
                {
                    ID = 2,
                    Name = "Orthopedics",
                    HospitalID = 1 // Assuming hospital ID is 1
                },
                new Department
                {
                    ID = 3,
                    Name = "Neurology",
                    HospitalID = 2 // Assuming hospital ID is 2
                },
                new Department
                {
                    ID = 4,
                    Name = "Oncology",
                    HospitalID = 2 // Assuming hospital ID is 2
                },
                new Department
                {
                    ID = 5,
                    HospitalID = 3,
                    Name = "Dermatology"
                },
                new Department
                {
                    ID = 6,
                    HospitalID = 3,
                    Name = "Endocrinology"
                },
                new Department
                {
                    ID = 7,
                    HospitalID = 4,
                    Name = "Gastroenterology"
                },
                new Department
                {
                    ID = 8,
                    HospitalID = 4,
                    Name = "Hematology"
                },
                new Department
                {
                    ID = 9,
                    HospitalID = 5,
                    Name = "Immunology"
                },
                new Department
                {
                    ID = 10,
                    HospitalID = 5,
                    Name = "Nephrology"
                });


            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    ID = 1,
                    Name = "MRI Machine",
                    Description = "High-field MRI machine for diagnostic imaging"
                },
                new Equipment
                {
                    ID = 2,
                    Name = "X-ray Machine",
                    Description = "X-ray machine for radiographic imaging"
                },
                new Equipment
                {
                    ID = 3,
                    Name = "Ultrasound Machine",
                    Description = "Ultrasound machine for medical imaging"
                },
                new Equipment
                {
                    ID = 4,
                    Name = "CT Scanner",
                    Description = "CT scanner for detailed cross-sectional images"
                },
                new Equipment
                {
                    ID = 5,
                    Name = "PET Scanner",
                    Description = "PET scanner for functional imaging"
                },
                new Equipment
                {
                    ID = 6,
                    Name = "Mammography Machine",
                    Description = "Mammography machine for breast imaging"
                },
                new Equipment
                {
                    ID = 7,
                    Name = "Fluoroscopy Machine",
                    Description = "Fluoroscopy machine for real-time imaging"
                },
                new Equipment
                {
                    ID = 8,
                    Name = "DEXA Scanner",
                    Description = "DEXA scanner for bone density measurement"
                },
                new Equipment
                {
                    ID = 9,
                    Name = "Gamma Camera",
                    Description = "Gamma camera for nuclear medicine imaging"
                },
                new Equipment
                {
                    ID = 10,
                    Name = "Endoscopy System",
                    Description = "Endoscopy system for internal imaging"
                });

            modelBuilder.Entity<Hospital>().HasData(
                new Hospital
                {
                    ID = 1,
                    Name = "Mount Sinai Hospital",
                    Phone = "+1-212-241-6500",
                    Government = "State Government",
                    City = "New York City",
                    Country = "United States",
                    Type = HospitalType.Public // Use enum value for Public hospital type
                },
                new Hospital
                {
                    ID = 2,
                    Name = "Mayo Clinic",
                    Phone = "+1-507-284-2511",
                    Government = "Local Government",
                    City = "Rochester",
                    Country = "United States",
                    Type = HospitalType.Private // Use enum value for Private hospital type
                },
                new Hospital
                {
                    ID = 3,
                    Name = "Cedars-Sinai Medical Center",
                    Phone = "+1-310-423-3277",
                    Government = "Private Hospital",
                    City = "Los Angeles",
                    Country = "United States",
                    Type = HospitalType.Private
                },
                new Hospital
                {
                    ID = 4,
                    Name = "Northwestern Memorial Hospital",
                    Phone = "+1-312-926-2000",
                    Government = "University Hospital",
                    City = "Chicago",
                    Country = "United States",
                    Type = HospitalType.Public
                },
                new Hospital
                {
                    ID = 5,
                    Name = "Michael E. DeBakey VA Medical Center",
                    Phone = "+1-713-791-1414",
                    Government = "Veterans Hospital",
                    City = "Houston",
                    Country = "United States",
                    Type = HospitalType.Private
                },
                new Hospital
                {
                    ID = 6,
                    Name = "Children's Hospital of Philadelphia",
                    Phone = "+1-215-590-1000",
                    Government = "Children's Hospital",
                    City = "Philadelphia",
                    Country = "United States",
                    Type = HospitalType.Public
                },
                new Hospital
                {
                    ID = 7,
                    Name = "Mayo Clinic Hospital",
                    Phone = "+1-480-515-6296",
                    Government = "Research Hospital",
                    City = "Phoenix",
                    Country = "United States",
                    Type = HospitalType.Private
                },
                new Hospital
                {
                    ID = 8,
                    Name = "University Hospital - University of Texas Health Science Center",
                    Phone = "+1-210-358-4000",
                    Government = "Teaching Hospital",
                    City = "San Antonio",
                    Country = "United States",
                    Type = HospitalType.Public
                },
                new Hospital
                {
                    ID = 9,
                    Name = "Scripps Memorial Hospital La Jolla",
                    Phone = "+1-858-626-4123",
                    Government = "Community Hospital",
                    City = "San Diego",
                    Country = "United States",
                    Type = HospitalType.Private
                },
                new Hospital
                {
                    ID = 10,
                    Name = "Children's Health - Children's Medical Center Dallas",
                    Phone = "+1-214-456-7000",
                    Government = "Children's Hospital",
                    City = "Dallas",
                    Country = "United States",
                    Type = HospitalType.Public
                });
            modelBuilder.Entity<Lab>().HasData(
                new Lab
                {
                    ID = 1,
                    Name = "Clinical Pathology Lab",
                    Type = LabType.XRay,
                    HospitalID = 1 // Assuming hospital ID, adjust accordingly
                },
                new Lab
                {
                    ID = 2,
                    Name = "Microbiology Lab",
                    Type = LabType.Lab,
                    HospitalID = 2 // Assuming hospital ID, adjust accordingly
                },
                new Lab
                {
                    ID = 3,
                    HospitalID = 3,
                    Name = "Chemistry Lab",
                    Type = LabType.XRay
                },
                new Lab
                {
                    ID = 4,
                    HospitalID = 4,
                    Name = "Hematology Lab",
                    Type = LabType.Lab
                },
                new Lab
                {
                    ID = 5,
                    HospitalID = 5,
                    Name = "Immunology Lab",
                    Type = LabType.Lab
                },
                new Lab
                {
                    ID = 6,
                    HospitalID = 6,
                    Name = "Genetics Lab",
                    Type = LabType.Lab
                },
                new Lab
                {
                    ID = 7,
                    HospitalID = 7,
                    Name = "Histology Lab",
                    Type = LabType.XRay
                },
                new Lab
                {
                    ID = 8,
                    HospitalID = 8,
                    Name = "Virology Lab",
                    Type = LabType.Lab
                },
                new Lab
                {
                    ID = 9,
                    HospitalID = 9,
                    Name = "Toxicology Lab",
                    Type = LabType.XRay
                },
                new Lab
                {
                    ID = 10,
                    HospitalID = 10,
                    Name = "Molecular Biology Lab",
                    Type = LabType.XRay
                });

            modelBuilder.Entity<Medicine>().HasData(
                new Medicine
                {
                    ID = 1,
                    Name = "Aspirin"
                },
                new Medicine
                {
                    ID = 2,
                    Name = "Paracetamol"
                },
                new Medicine
                {
                    ID = 3,
                    Name = "Ibuprofen"
                },
                new Medicine
                {
                    ID = 4,
                    Name = "Acetaminophen"
                },
                new Medicine
                {
                    ID = 5,
                    Name = "Omeprazole"
                },
                new Medicine
                {
                    ID = 6,
                    Name = "Lisinopril"
                },
                new Medicine
                {
                    ID = 7,
                    Name = "Metformin"
                },
                new Medicine
                {
                    ID = 8,
                    Name = "Simvastatin"
                },
                new Medicine
                {
                    ID = 9,
                    Name = "Atorvastatin"
                },
                new Medicine
                {
                    ID = 10,
                    Name = "Levothyroxine"
                }
            // Add more medicines as needed
            );
            modelBuilder.Entity<MedicineType>().HasData(
                new MedicineType
                {
                    ID = 1,
                    MedicineID = 1, // Assuming medicine ID, adjust accordingly
                    TypeID = 1, // Assuming type ID, adjust accordingly
                    Description = "Painkiller",
                    SideEffects = "May cause drowsiness",
                    Warning = "Do not exceed recommended dosage",
                    ExpirationDate = new DateTime(2023, 12, 31)
                },
                new MedicineType
                {
                    ID = 2,
                    MedicineID = 2, // Assuming medicine ID, adjust accordingly
                    TypeID = 2, // Assuming type ID, adjust accordingly
                    Description = "Antibiotic",
                    SideEffects = "Possible nausea and diarrhea",
                    Warning = "Take with food",
                    ExpirationDate = new DateTime(2024, 10, 15)
                },
                new MedicineType
                {
                    ID = 3,
                    MedicineID = 3, // Assuming medicine ID, adjust accordingly
                    TypeID = 3, // Assuming type ID, adjust accordingly
                    Description = "Antacid",
                    SideEffects = "Relieves heartburn",
                    Warning = "Avoid taking other medications within 2 hours",
                    ExpirationDate = new DateTime(2024, 6, 30)
                },
                new MedicineType
                {
                    ID = 4,
                    MedicineID = 4, // Assuming medicine ID, adjust accordingly
                    TypeID = 4, // Assuming type ID, adjust accordingly
                    Description = "Antihistamine",
                    SideEffects = "May cause drowsiness",
                    Warning = "Avoid alcohol while taking",
                    ExpirationDate = new DateTime(2023, 11, 15)
                },
                new MedicineType
                {
                    ID = 5,
                    MedicineID = 5, // Assuming medicine ID, adjust accordingly
                    TypeID = 5, // Assuming type ID, adjust accordingly
                    Description = "Anti-inflammatory",
                    SideEffects = "Take with food or milk",
                    Warning = "Not recommended for long-term use",
                    ExpirationDate = new DateTime(2024, 8, 25)
                },
                new MedicineType
                {
                    ID = 6,
                    MedicineID = 6, // Assuming medicine ID, adjust accordingly
                    TypeID = 6, // Assuming type ID, adjust accordingly
                    Description = "Antidepressant",
                    SideEffects = "May take several weeks to see effects",
                    Warning = "Do not abruptly discontinue",
                    ExpirationDate = new DateTime(2025, 2, 28)
                },
                new MedicineType
                {
                    ID = 7,
                    MedicineID = 7, // Assuming medicine ID, adjust accordingly
                    TypeID = 7, // Assuming type ID, adjust accordingly
                    Description = "Anticoagulant",
                    SideEffects = "Increased risk of bleeding",
                    Warning = "Regular monitoring required",
                    ExpirationDate = new DateTime(2023, 10, 10)
                },
                new MedicineType
                {
                    ID = 8,
                    MedicineID = 8, // Assuming medicine ID, adjust accordingly
                    TypeID = 8, // Assuming type ID, adjust accordingly
                    Description = "Antidiabetic",
                    SideEffects = "Monitor blood sugar levels regularly",
                    Warning = "Report any unusual symptoms to doctor",
                    ExpirationDate = new DateTime(2024, 4, 20)
                },
                new MedicineType
                {
                    ID = 9,
                    MedicineID = 9, // Assuming medicine ID, adjust accordingly
                    TypeID = 9, // Assuming type ID, adjust accordingly
                    Description = "Antiemetic",
                    SideEffects = "May cause drowsiness or dizziness",
                    Warning = "Avoid driving or operating machinery",
                    ExpirationDate = new DateTime(2024, 7, 15)
                },
                new MedicineType
                {
                    ID = 10,
                    MedicineID = 10, // Assuming medicine ID, adjust accordingly
                    TypeID = 10, // Assuming type ID, adjust accordingly
                    Description = "Antifungal",
                    SideEffects = "Apply as directed to affected area",
                    Warning = "Complete full course of treatment",
                    ExpirationDate = new DateTime(2023, 9, 5)
                }
            // Add more medicine types as needed
            );
            modelBuilder.Entity<Pharmacy>().HasData(
                new Pharmacy
                {
                    ID = 1,
                    Name = "Walgreens",
                    HospitalID = 1 // Assuming hospital ID, adjust accordingly
                },
                new Pharmacy
                {
                    ID = 2,
                    Name = "CVS Pharmacy",
                    HospitalID = 2 // Assuming hospital ID, adjust accordingly
                },
                new Pharmacy
                {
                    ID = 3,
                    HospitalID = 3,
                    Name = "Rite Aid"
                },
                new Pharmacy
                {
                    ID = 4,
                    HospitalID = 4,
                    Name = "Walmart Pharmacy"
                },
                new Pharmacy
                {
                    ID = 5,
                    HospitalID = 5,
                    Name = "Target Pharmacy"
                },
                new Pharmacy
                {
                    ID = 6,
                    HospitalID = 6,
                    Name = "Kroger Pharmacy"
                },
                new Pharmacy
                {
                    ID = 7,
                    HospitalID = 7,
                    Name = "Costco Pharmacy"
                },
                new Pharmacy
                {
                    ID = 8,
                    HospitalID = 8,
                    Name = "Publix Pharmacy"
                },
                new Pharmacy
                {
                    ID = 9,
                    HospitalID = 9,
                    Name = "Wal-Mart Pharmacy"
                },
                new Pharmacy
                {
                    ID = 10,
                    HospitalID = 10,
                    Name = "Safeway Pharmacy"
                }

            // Add more pharmacies as needed
            );
            modelBuilder.Entity<PharmacyMedicine>().HasData(
                new PharmacyMedicine
                {
                    ID = 1,
                    PharmacyID = 1, // Assuming pharmacy ID, adjust accordingly
                    MedicineTypeID = 1, // Assuming medicine type ID, adjust accordingly
                    Amount = 50,
                    Price = 10.99 // Assuming price, adjust accordingly
                },
                new PharmacyMedicine
                {
                    ID = 2,
                    PharmacyID = 2, // Assuming pharmacy ID, adjust accordingly
                    MedicineTypeID = 2, // Assuming medicine type ID, adjust accordingly
                    Amount = 100,
                    Price = 5.99 // Assuming price, adjust accordingly
                },
                new PharmacyMedicine
                {
                    ID = 3,
                    Amount = 75,
                    MedicineTypeID = 3,
                    PharmacyID = 3,
                    Price = 15.49
                },
                new PharmacyMedicine
                {
                    ID = 4,
                    Amount = 200,
                    MedicineTypeID = 4,
                    PharmacyID = 4,
                    Price = 8.75
                },
                new PharmacyMedicine
                {
                    ID = 5,
                    Amount = 150,
                    MedicineTypeID = 5,
                    PharmacyID = 5,
                    Price = 12.25
                },
                new PharmacyMedicine
                {
                    ID = 6,
                    Amount = 120,
                    MedicineTypeID = 6,
                    PharmacyID = 6,
                    Price = 9.99
                },
                new PharmacyMedicine
                {
                    ID = 7,
                    Amount = 80,
                    MedicineTypeID = 7,
                    PharmacyID = 7,
                    Price = 17.50
                },
                new PharmacyMedicine
                {
                    ID = 8,
                    Amount = 90,
                    MedicineTypeID = 8,
                    PharmacyID = 8,
                    Price = 14.75
                },
                new PharmacyMedicine
                {
                    ID = 9,
                    Amount = 110,
                    MedicineTypeID = 9,
                    PharmacyID = 9,
                    Price = 11.25
                },
                new PharmacyMedicine
                {
                    ID = 10,
                    Amount = 70,
                    MedicineTypeID = 10,
                    PharmacyID = 10,
                    Price = 19.99
                });

            modelBuilder.Entity<PlaceEquipment>().HasData(
                new PlaceEquipment
                {
                    ID = 1,
                    EquipmentID = 1, // Assuming equipment ID, adjust accordingly
                    EntityID = 1, // Assuming entity ID (clinic, lab, or pharmacy), adjust accordingly
                    PlaceType = PlaceType.Lab // Assuming place type, adjust accordingly
                },
                new PlaceEquipment
                {
                    ID = 2,
                    EquipmentID = 2, // Assuming equipment ID, adjust accordingly
                    EntityID = 2, // Assuming entity ID (clinic, lab, or pharmacy), adjust accordingly
                    PlaceType = PlaceType.Lab // Assuming place type, adjust accordingly
                },
                new PlaceEquipment
                {
                    ID = 3,
                    EntityID = 3,
                    EquipmentID = 3,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 4,
                    EntityID = 4,
                    EquipmentID = 4,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 5,
                    EntityID = 5,
                    EquipmentID = 5,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 6,
                    EntityID = 6,
                    EquipmentID = 6,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 7,
                    EntityID = 7,
                    EquipmentID = 7,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 8,
                    EntityID = 8,
                    EquipmentID = 8,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 9,
                    EntityID = 9,
                    EquipmentID = 9,
                    PlaceType = PlaceType.Lab
                },
                new PlaceEquipment
                {
                    ID = 10,
                    EntityID = 10,
                    EquipmentID = 10,
                    PlaceType = PlaceType.Lab
                });

            modelBuilder.Entity<PlaceShift>().HasData(
                new PlaceShift
                {
                    ID = 1,
                    EntityID = 1, // Assuming entity ID (clinic, lab, or pharmacy), adjust accordingly
                    PlaceType = PlaceType.Lab, // Assuming place type, adjust accordingly
                    ShiftID = 1 // Assuming shift ID, adjust accordingly
                },
                new PlaceShift
                {
                    ID = 2,
                    EntityID = 2, // Assuming entity ID (clinic, lab, or pharmacy), adjust accordingly
                    PlaceType = PlaceType.Lab, // Assuming place type, adjust accordingly
                    ShiftID = 2 // Assuming shift ID, adjust accordingly
                },
                new PlaceShift
                {
                    ID = 3,
                    EntityID = 3,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 2
                },
                new PlaceShift
                {
                    ID = 4,
                    EntityID = 4,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 1
                },
                new PlaceShift
                {
                    ID = 5,
                    EntityID = 5,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 2
                },
                new PlaceShift
                {
                    ID = 6,
                    EntityID = 6,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 1
                },
                new PlaceShift
                {
                    ID = 7,
                    EntityID = 7,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 2
                },
                new PlaceShift
                {
                    ID = 8,
                    EntityID = 8,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 1
                },
                new PlaceShift
                {
                    ID = 9,
                    EntityID = 9,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 2
                },
                new PlaceShift
                {
                    ID = 10,
                    EntityID = 10,
                    PlaceType = PlaceType.Lab,
                    ShiftID = 1
                }
            // Add more place-shift associations as needed
            );
            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    ID = 1,
                    Time = DateTime.Now.AddDays(-1), // Example date and time, adjust accordingly
                    Description = "Description of report 1",
                    UserID = "1", // Assuming user ID, adjust accordingly
                    DoctorID = "11" // Assuming doctor ID, adjust accordingly
                    
                },
                new Report
                {
                    ID = 2,
                    Time = DateTime.Now.AddDays(-2), // Example date and time, adjust accordingly
                    Description = "Description of report 2",
                    UserID = "2", // Assuming user ID, adjust accordingly
                    DoctorID = "22" // Assuming doctor ID, adjust accordingly
                },
                new Report
                {
                    ID = 3,
                    Time = new DateTime(2024, 3, 1, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6357),
                    Description = "Description of report 3",
                    UserID = "1",
                    DoctorID = "1"
                },
                new Report
                {
                    ID = 4,
                    Time = new DateTime(2024, 3, 2, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6431),
                    Description = "Description of report 4",
                    UserID = "2",
                    DoctorID = "2"
                },
                new Report
                {
                    ID = 5,
                    Time = new DateTime(2024, 3, 3, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6505),
                    Description = "Description of report 5",
                    UserID = "3",
                    DoctorID = "3"
                },
                new Report
                {
                    ID = 6,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6579),
                    Description = "Description of report 6",
                    UserID = "4",
                    DoctorID = "4"
                },
                new Report
                {
                    ID = 7,
                    Time = new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6653),
                    Description = "Description of report 7",
                    UserID = "5",
                    DoctorID = "5"
                },
                new Report
                {
                    ID = 8,
                    Time = new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6727),
                    Description = "Description of report 8",
                    UserID = "6",
                    DoctorID = "6"
                },
                new Report
                {
                    ID = 9,
                    Time = new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6801),
                    Description = "Description of report 9",
                    UserID = "7",
                    DoctorID = "7"
                },
                new Report
                {
                    ID = 10,
                    Time = new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6875),
                    Description = "Description of report 10",
                    UserID = "8",
                    DoctorID = "8"
                });

            modelBuilder.Entity<ReportMedicine>().HasData(
                new ReportMedicine
                {
                    ID = 1,
                    ReportID = 1, // Assuming report ID, adjust accordingly
                    MedicineTypeID = 1 // Assuming medicine type ID, adjust accordingly
                },
                new ReportMedicine
                {
                    ID = 2,
                    ReportID = 2, // Assuming report ID, adjust accordingly
                    MedicineTypeID = 2 // Assuming medicine type ID, adjust accordingly
                },
                new ReportMedicine
                {
                    ID = 3,
                    MedicineTypeID = 3,
                    ReportID = 3
                },
                new ReportMedicine
                {
                    ID = 4,
                    MedicineTypeID = 4,
                    ReportID = 4
                },
                new ReportMedicine
                {
                    ID = 5,
                    MedicineTypeID = 5,
                    ReportID = 5
                },
                new ReportMedicine
                {
                    ID = 6,
                    MedicineTypeID = 6,
                    ReportID = 6
                },
                new ReportMedicine
                {
                    ID = 7,
                    MedicineTypeID = 7,
                    ReportID = 7
                },
                new ReportMedicine
                {
                    ID = 8,
                    MedicineTypeID = 8,
                    ReportID = 8
                },
                new ReportMedicine
                {
                    ID = 9,
                    MedicineTypeID = 9,
                    ReportID = 9
                },
                new ReportMedicine
                {
                    ID = 10,
                    MedicineTypeID = 10,
                    ReportID = 10
                });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ID = 1,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(741),
                    State = ReservationState.Done,
                    PlacePriceId = 1,
                    UserID = "1" ,
                    SerialNumber="45165153"
                },
                new Reservation
                {
                    ID = 2,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(1531),
                    State = ReservationState.Running,
                    PlacePriceId = 1,
                    UserID = "2" ,
                    SerialNumber="543864963"
                },
                new Reservation
                {
                    ID = 3,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6478),
                    State = ReservationState.Done,
                    PlacePriceId = 2,
                    UserID = "3",
                    SerialNumber = "70000001"
                },
                new Reservation
                {
                    ID = 4,
                    Time = new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6491),
                    State = ReservationState.Done,
                    PlacePriceId = 2,
                    UserID = "4",
                    SerialNumber = "70000002"
                },
                new Reservation
                {
                    ID = 5,
                    Time = new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6504),
                    State = ReservationState.Done,
                    PlacePriceId = 3,
                    UserID = "5",
                    SerialNumber = "70000003"
                },
                new Reservation
                {
                    ID = 6,
                    Time = new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6517),
                    State = ReservationState.Done,
                    PlacePriceId = 3,
                    UserID = "6",
                    SerialNumber = "70000004"
                },
                new Reservation
                {
                    ID = 7,
                    Time = new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6530),
                    State = ReservationState.Running,
                    PlacePriceId = 1,
                    UserID = "7",
                    SerialNumber = "70000005"
                },
                new Reservation
                {
                    ID = 8,
                    Time = new DateTime(2024, 3, 9, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6543),
                    State = ReservationState.Running,
                    PlacePriceId = 1,
                    UserID = "8",
                    SerialNumber = "70000006"
                },
                new Reservation
                {
                    ID = 9,
                    Time = new DateTime(2024, 3, 10, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6556),
                    State = ReservationState.Running,
                    PlacePriceId = 1,
                    UserID = "9",
                    SerialNumber = "70000007"
                },
                new Reservation
                {
                    ID = 10,
                    Time = new DateTime(2024, 3, 11, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6569),
                    State = ReservationState.Done,
                    PlacePriceId = 1,
                    UserID = "10",
                    SerialNumber = "70000008"
                }

            // Add more reservations as needed
            );
            modelBuilder.Entity<Shift>().HasData(
                new Shift
                {
                    ID = 1,
                    Name = "Morning Shift",
                    StartTime = new DateTime(2024, 2, 17, 8, 0, 0), // Example start time, adjust accordingly
                    EndTime = new DateTime(2024, 2, 17, 16, 0, 0), // Example end time, adjust accordingly
                    EntityID = 1, // Assuming entity ID, adjust accordingly
                    PlaceType = PlaceType.Lab // Assuming place type, adjust accordingly
                },
                new Shift
                {
                    ID = 2,
                    Name = "Evening Shift",
                    StartTime = new DateTime(2024, 2, 17, 16, 0, 0), // Example start time, adjust accordingly
                    EndTime = new DateTime(2024, 2, 17, 23, 0, 0), // Example end time, adjust accordingly
                    EntityID = 2, // Assuming entity ID, adjust accordingly
                    PlaceType = PlaceType.Lab // Assuming place type, adjust accordingly
                },
                new Shift
                {
                    ID = 3,
                    Name = "Morning Shift",
                    StartTime = new DateTime(2024, 2, 17, 8, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EntityID = 3,
                    PlaceType = PlaceType.  Lab
                },
                new Shift
                {
                    ID = 4,
                    Name = "Evening Shift",
                    StartTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 23, 0, 0),
                    EntityID = 4,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 5,
                    Name = "Morning Shift",
                    StartTime = new DateTime(2024, 2, 17, 8, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EntityID = 5,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 6,
                    Name = "Evening Shift",
                    StartTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 23, 0, 0),
                    EntityID = 6,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 7,
                    Name = "Morning Shift",
                    StartTime = new DateTime(2024, 2, 17, 8, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EntityID = 7,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 8,
                    Name = "Evening Shift",
                    StartTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 23, 0, 0),
                    EntityID = 8,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 9,
                    Name = "Morning Shift",
                    StartTime = new DateTime(2024, 2, 17, 8, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EntityID = 9,
                    PlaceType = PlaceType.Lab
                },
                new Shift
                {
                    ID = 10,
                    Name = "Evening Shift",
                    StartTime = new DateTime(2024, 2, 17, 16, 0, 0),
                    EndTime = new DateTime(2024, 2, 17, 23, 0, 0),
                    EntityID = 10,
                    PlaceType = PlaceType.Lab
                });
            modelBuilder.Entity<TestLab>().HasData(
                new TestLab
                {
                    ID = 1,
                    TestID = 1, // Assuming test lab ID, adjust accordingly
                    LabID = 1, // Assuming lab ID, adjust accordingly
                    Price = 100.00, // Assuming price, adjust accordingly
                    Description = "Description of test lab 1"
                },
                new TestLab
                {
                    ID = 2,
                    TestID = 2, // Assuming test lab ID, adjust accordingly
                    LabID = 2, // Assuming lab ID, adjust accordingly
                    Price = 150.00, // Assuming price, adjust accordingly
                    Description = "Description of test lab 2"
                },
                new TestLab
                {
                    ID = 3,
                    Description = "Description of test lab 3",
                    LabID = 3,
                    Price = 200.0,
                    TestID = 3
                });
            modelBuilder.Entity<Attachment>().HasData(
                    new Attachment
                    {
                        ID = 1,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl="lol",
                        ViewUrl="lol",
                    },
                    new Attachment
                    {
                        ID = 2,
                        FileName = "6bb72574-4c96-4d5a-8ff2-d0ebf750631f.jpeg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\6bb72574-4c96-4d5a-8ff2-d0ebf750631f.jpeg",
                        FolderName = "Test",
                        Title = "Sample Attachment 2",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    },
                    new Attachment
                    {
                        ID = 3,
                        FileName = "edfdf2bd-7ff0-48aa-a4db-8dfc0fa11a2a.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\edfdf2bd-7ff0-48aa-a4db-8dfc0fa11a2a.jpg",
                        FolderName = "Test",
                        Title = "Sample Attachment 3",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    // Add more attachments as needed
                    ,new Attachment
                    {
                        ID = 4,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 5,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 6,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 7,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 8,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 9,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                    , new Attachment
                    {
                        ID = 10,
                        FileName = "33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        Filepath = "D:\\Final Project\\MedicalSystem\\BackEnd\\Medical System\\wwwroot\\Test\\33c1aa8a-c108-42cb-9686-7414da0d0492.jpg",
                        FolderName = "Test", // Assuming these are test attachments
                        Title = "Sample Attachment 1",
                        Type = "Image",
                        DownloadUrl = "lol",
                        ViewUrl = "lol",
                    }
                );
            modelBuilder.Entity<Test>().HasData(
                new Test
                {
                    ID = 1,
                    Name = "Blood Test",
                    PhotoID=1
                },
                new Test
                {
                    ID = 2,
                    Name = "Urinalysis",
                    PhotoID=2
                },
                new Test
                {
                    ID = 3,
                    Name = "MRI Scan",
                    PhotoID=3
                }
               );

            modelBuilder.Entity<Types>().HasData(
                new Types
                {
                    ID = 1,
                    Name = "Type 1"
                },
                new Types
                {
                    ID = 2,
                    Name = "Type 2"
                },
                new Types
                {
                    ID = 3,
                    Name = "Type 3"
                },
                new Types
                {
                    ID = 4,
                    Name = "Type 4"
                },
                new Types
                {
                    ID = 5,
                    Name = "Type 5"
                },
                new Types
                {
                    ID = 6,
                    Name = "Type 6"
                },
                new Types
                {
                    ID = 7,
                    Name = "Type 7"
                },
                new Types
                {
                    ID = 8,
                    Name = "Type 8"
                },
                new Types
                {
                    ID = 9,
                    Name = "Type 9"
                },
                new Types
                {
                    ID = 10,
                    Name = "Type 10"
                });
            modelBuilder.Entity<Disease>().HasData(
                new Disease
                {
                    ID = 1,
                    Name = "Diabetes",
                    Description = "A chronic condition that affects how your body turns food into energy.",
                    Symptoms = "Increased thirst, frequent urination, extreme hunger, unexplained weight loss, presence of ketones in the urine.",
                    Causes = "Genetic factors, poor diet, lack of exercise, obesity."
                },
                new Disease
                {
                    ID = 2,
                    Name = "Hypertension",
                    Description = "A condition in which the force of the blood against the artery walls is too high.",
                    Symptoms = "Often has no symptoms but can include headaches, shortness of breath, or nosebleeds.",
                    Causes = "Genetic factors, high salt intake, obesity, lack of physical activity, alcohol consumption."
                },
                new Disease
                {
                    ID = 3,
                    Name = "Asthma",
                    Description = "A condition in which your airways narrow and swell and produce extra mucus.",
                    Symptoms = "Shortness of breath, chest tightness or pain, wheezing, coughing.",
                    Causes = "Genetic factors, respiratory infections, allergens, air pollutants."
                },
                new Disease
                {
                    ID = 4,
                    Name = "Cancer",
                    Description = "A group of diseases involving abnormal cell growth with the potential to invade or spread to other parts of the body.",
                    Symptoms = "Varies by type but can include lumps, abnormal bleeding, prolonged cough, unexplained weight loss.",
                    Causes = "Genetic factors, lifestyle factors such as smoking and diet, environmental exposures to chemicals and radiation."
                },
                new Disease
                {
                    ID = 5,
                    Name = "Alzheimer's Disease",
                    Description = "A progressive disorder that causes brain cells to waste away (degenerate) and die.",
                    Symptoms = "Memory loss, confusion, difficulty with language, difficulty in making decisions, personality changes.",
                    Causes = "Genetic factors, age, family history, certain genetic mutations."
                });
            modelBuilder.Entity<ApplicationUserDisease>().HasData(
                new ApplicationUserDisease
                {
                    ID = 1,
                    Type = "Type 1 Diabetes",
                    ValueResult = 7.2,
                    Description = "Managed with insulin injections.",
                    Height = 1.75,
                    Weight = 70.0,
                    ApplicationUserId = "1", // This should match an existing ApplicationUser ID
                    DiseaseId = 1, // This should match an existing Disease ID
                    Diagnosis = "Confirmed Type 1 Diabetes",
                    DiagnosisDate = new DateTime(2020, 1, 15),
                    Attachments = new List<Attachment>()
                },
                new ApplicationUserDisease
                {
                    ID = 2,
                    Type = "Hypertension",
                    ValueResult = 140,
                    Description = "High blood pressure managed with medication.",
                    Height = 1.80,
                    Weight = 85.0,
                    ApplicationUserId = "2", // This should match an existing ApplicationUser ID
                    DiseaseId = 2, // This should match an existing Disease ID
                    Diagnosis = "Stage 2 Hypertension",
                    DiagnosisDate = new DateTime(2019, 5, 10),
                    Attachments = new List<Attachment>()
                },
                new ApplicationUserDisease
                {
                    ID = 3,
                    Type = "Asthma",
                    ValueResult = 1,
                    Description = "Chronic condition managed with inhalers.",
                    Height = 1.65,
                    Weight = 60.0,
                    ApplicationUserId = "3", // This should match an existing ApplicationUser ID
                    DiseaseId = 3, // This should match an existing Disease ID
                    Diagnosis = "Mild Persistent Asthma",
                    DiagnosisDate = new DateTime(2018, 3, 20),
                    Attachments = new List<Attachment>()
                },
                new ApplicationUserDisease
                {
                    ID = 4,
                    Type = "Cancer",
                    ValueResult = 3.4,
                    Description = "Undergoing chemotherapy.",
                    Height = 1.70,
                    Weight = 65.0,
                    ApplicationUserId = "4", // This should match an existing ApplicationUser ID
                    DiseaseId = 4, // This should match an existing Disease ID
                    Diagnosis = "Stage 2 Breast Cancer",
                    DiagnosisDate = new DateTime(2021, 8, 30),
                    Attachments = new List<Attachment>()
                },
                new ApplicationUserDisease
                {
                    ID = 5,
                    Type = "Alzheimer's Disease",
                    ValueResult = 4.5,
                    Description = "Progressive memory loss.",
                    Height = 1.60,
                    Weight = 55.0,
                    ApplicationUserId = "5", // This should match an existing ApplicationUser ID
                    DiseaseId = 5, // This should match an existing Disease ID
                    Diagnosis = "Early Onset Alzheimer's",
                    DiagnosisDate = new DateTime(2017, 12, 10),
                    Attachments = new List<Attachment>()
                }
            );

            #endregion

            #region Configs
            new ClinicConfig().Configure(modelBuilder.Entity<Clinic>());
            new PlacePriceConfig().Configure(modelBuilder.Entity<PlacePrice>());
            new DepartmentConfig().Configure(modelBuilder.Entity<Department>());
            new AttachmentConfig().Configure(modelBuilder.Entity<Attachment>());
            new EquipmentConfig().Configure(modelBuilder.Entity<Equipment>());
            new HospitalConfig().Configure(modelBuilder.Entity<Hospital>());
            new LabConfig().Configure(modelBuilder.Entity<Lab>());
            new MedicineConfig().Configure(modelBuilder.Entity<Medicine>());
            new MedicineTypeConfig().Configure(modelBuilder.Entity<MedicineType>());
            new PharmacyConfig().Configure(modelBuilder.Entity<Pharmacy>());
            new PharmacyMedicineConfig().Configure(modelBuilder.Entity<PharmacyMedicine>());
            new PlaceEquipmentConfig().Configure(modelBuilder.Entity<PlaceEquipment>());
            new PlaceShiftConfig().Configure(modelBuilder.Entity<PlaceShift>());
            new ReportConfig().Configure(modelBuilder.Entity<Report>());
            new ReportMedicineConfig().Configure(modelBuilder.Entity<ReportMedicine>());
            new ReservationConfig().Configure(modelBuilder.Entity<Reservation>());
            new ShiftConfig().Configure(modelBuilder.Entity<Shift>());
            new TestConfig().Configure(modelBuilder.Entity<Test>());
            new TestLabConfig().Configure(modelBuilder.Entity<TestLab>());
            new TypesConfig().Configure(modelBuilder.Entity<Types>());
            new UserConfig().Configure(modelBuilder.Entity<ApplicationUser>()); 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #region DbSets
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<ApplicationUserDisease> UserDiseases { get; set; }  
        public DbSet<OTP> OTPs { get; set; }
        public DbSet<Clinic> clinics { get; set; }
        public DbSet<PlacePrice> placePrice { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Attachment> attachments { get; set; }
        public DbSet<Equipment> equipments { get; set; }
        public DbSet<Hospital> hospitals { get; set; }
        public DbSet<Lab> labs { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<MedicineType> medicinesType { get; set; }
        public DbSet<Pharmacy> pharmacies { get; set; }
        public DbSet<PharmacyMedicine> pharmacyMedicines { get; set; }
        public DbSet<PlaceEquipment> placeEquipments { get; set; }
        public DbSet<PlaceShift> placeShifts { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<ReportMedicine> reportsMedicines { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Shift> shifts { get; set; }
        public DbSet<Test> tests { get; set; }
        public DbSet<TestLab> testLabs { get; set; }
        public DbSet<Types> types { get; set; }
        public DbSet<ApplicationUser> users { get; set; }
        #endregion
    }
}
