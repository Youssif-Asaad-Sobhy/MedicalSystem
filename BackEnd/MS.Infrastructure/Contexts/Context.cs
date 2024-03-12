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
                    Id = "1", // Generate a unique ID
                    NID = "2636523632",
                    Gender = "male",
                    BirthDate = new DateTime(2002, 9, 25),
                    UserName = "MohamedAli123",
                    NormalizedEmail = "MOHAMED@EXAMPLE.COM",
                    NormalizedUserName = "MOHAMEDALI123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "2", // Generate another unique ID
                    NID = "5312523632",
                    Gender = "Female",
                    BirthDate = new DateTime(2012, 6, 25),
                    UserName = "monaomar123",
                    NormalizedEmail = "MONA@EXAMPLE.COM",
                    NormalizedUserName = "MONAOMAR123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "3",
                    Name = "Mohammed",
                    NID = "9876543210",
                    Gender = "Male",
                    BirthDate = new DateTime(1988, 10, 5),
                    UserName = "MOHAMMED123",
                    NormalizedEmail = "MOHAMMED@EXAMPLE.COM",
                    NormalizedUserName = "MOHAMMED123",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "4",
                    Name = "Aisha",
                    NID = "0123456789",
                    Gender = "Female",
                    BirthDate = new DateTime(1995, 3, 25),
                    UserName = "AISHA321",
                    NormalizedEmail = "AISHA@EXAMPLE.COM",
                    NormalizedUserName = "AISHA321",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "5",
                    Name = "Ahmad",
                    NID = "1122334455",
                    Gender = "Male",
                    BirthDate = new DateTime(1978, 3, 10),
                    UserName = "AHMAD567",
                    NormalizedEmail = "AHMAD@EXAMPLE.COM",
                    NormalizedUserName = "AHMAD567",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "6",
                    Name = "Aya",
                    NID = "3344556677",
                    Gender = "Female",
                    BirthDate = new DateTime(1989, 7, 5),
                    UserName = "AYA789",
                    NormalizedEmail = "AYA@EXAMPLE.COM",
                    NormalizedUserName = "AYA789",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "7",
                    Name = "Omar",
                    NID = "5544332211",
                    Gender = "Male",
                    BirthDate = new DateTime(1995, 12, 12),
                    UserName = "OMAR101",
                    NormalizedEmail = "OMAR@EXAMPLE.COM",
                    NormalizedUserName = "OMAR101",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "8",
                    Name = "Sara",
                    NID = "7788990011",
                    Gender = "Female",
                    BirthDate = new DateTime(1980, 1, 30),
                    UserName = "SARA2022",
                    NormalizedEmail = "SARA@EXAMPLE.COM",
                    NormalizedUserName = "SARA2022",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "9",
                    Name = "Ali",
                    NID = "6677889900",
                    Gender = "Male",
                    BirthDate = new DateTime(1998, 5, 20),
                    UserName = "ALI3030",
                    NormalizedEmail = "ALI@EXAMPLE.COM",
                    NormalizedUserName = "ALI3030",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                },
                new ApplicationUser
                {
                    Id = "10",
                    Name = "Laila",
                    NID = "1122334455",
                    Gender = "Female",
                    BirthDate = new DateTime(1982, 10, 10),
                    UserName = "LAILA4040",
                    NormalizedEmail = "LAILA@EXAMPLE.COM",
                    NormalizedUserName = "LAILA4040",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                });

            modelBuilder.Entity<Clinic>().HasData(
                new Clinic
                {
                    ID = 1,
                    Name = "Elzahraa",
                    DepartmentID = 1,

                },
                new Clinic
                {
                    ID = 2,
                    Name = "Alpha",
                    DepartmentID = 2,

                },
                new Clinic
                {
                    ID = 3,
                    DepartmentID = 3,
                    Name = "Mediplus"
                },
                new Clinic
                {
                    ID = 4,
                    DepartmentID = 4,
                    Name = "HealthLine"
                },
                new Clinic
                {
                    ID = 5,
                    DepartmentID = 5,
                    Name = "MediCare"
                },
                new Clinic
                {
                    ID = 6,
                    DepartmentID = 6,
                    Name = "Wellness Pharmacy"
                },
                new Clinic
                {
                    ID = 7,
                    DepartmentID = 7,
                    Name = "CarePlus"
                },
                new Clinic
                {
                    ID = 8,
                    DepartmentID = 8,
                    Name = "MediPharm"
                },
                new Clinic
                {
                    ID = 9,
                    DepartmentID = 9,
                    Name = "MediCo"
                },
                new Clinic
                {
                    ID = 10,
                    DepartmentID = 10,
                    Name = "PharmaCare"
                });

            modelBuilder.Entity<PlacePrice>().HasData(
                new PlacePrice
                {
                    ID = 1,
                    Name = "X-Alpha",
                    Price = 341.40,
                    PlaceID = 2,
                    PlaceType=PlaceType.Clinic
                   
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
                    ID = 2,
                    Name = "X-Beta",
                    PlaceID = 3,
                    PlaceType = PlaceType.Pharmacy,
                    Price = 419.99
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
                    Name = "CT Scan",
                    PlaceID = 5,
                    PlaceType = PlaceType.Clinic,
                    Price = 799.99
                },
                new PlacePrice
                {
                    ID = 6,
                    Name = "Ultrasound",
                    PlaceID = 6,
                    PlaceType = PlaceType.Clinic,
                    Price = 499.99
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
                    PlaceType = PlaceType.Clinic,
                    Price = 299.99
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

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    ID = 1,
                    Content = new byte[] { /* content bytes */ }, // Replace with actual document content
                    ReportID = 1 // Assuming report ID is 1
                },
                new Document
                {
                    ID = 2,
                    Content = new byte[] { /* content bytes */ }, // Replace with actual document content
                    ReportID = 2 // Assuming report ID is 2
                },
                new Document
                {
                    ID = 3,
                    Content = new byte[0] { },
                    ReportID = 3
                },
                new Document
                {
                    ID = 4,
                    Content = new byte[0] { },
                    ReportID = 4
                },
                new Document
                {
                    ID = 5,
                    Content = new byte[0] { },
                    ReportID = 5
                },
                new Document
                {
                    ID = 6,
                    Content = new byte[0] { },
                    ReportID = 6
                },
                new Document
                {
                    ID = 7,
                    Content = new byte[0] { },
                    ReportID = 7
                },
                new Document
                {
                    ID = 8,
                    Content = new byte[0] { },
                    ReportID = 8
                },
                new Document
                {
                    ID = 9,
                    Content = new byte[0] { },
                    ReportID = 9
                },
                new Document
                {
                    ID = 10,
                    Content = new byte[0] { },
                    ReportID = 10
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
                    PlaceType = PlaceType.Clinic // Assuming place type, adjust accordingly
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic, // Assuming place type, adjust accordingly
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
                    PlaceType = PlaceType.Clinic,
                    ShiftID = 2
                },
                new PlaceShift
                {
                    ID = 6,
                    EntityID = 6,
                    PlaceType = PlaceType.Clinic,
                    ShiftID = 1
                },
                new PlaceShift
                {
                    ID = 7,
                    EntityID = 7,
                    PlaceType = PlaceType.Clinic,
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
                    PlaceType = PlaceType.Clinic,
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
                    SerialNumber=45165153
                },
                new Reservation
                {
                    ID = 2,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(1531),
                    State = ReservationState.Running,
                    PlacePriceId = 1,
                    UserID = "2" ,
                    SerialNumber=543864963
                },
                new Reservation
                {
                    ID = 3,
                    Time = new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6478),
                    State = ReservationState.Done,
                    PlacePriceId = 2,
                    UserID = "3",
                    SerialNumber = 70000001
                },
                new Reservation
                {
                    ID = 4,
                    Time = new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6491),
                    State = ReservationState.Done,
                    PlacePriceId = 2,
                    UserID = "4",
                    SerialNumber = 70000002
                },
                new Reservation
                {
                    ID = 5,
                    Time = new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6504),
                    State = ReservationState.Done,
                    PlacePriceId = 3,
                    UserID = "5",
                    SerialNumber = 70000003
                },
                new Reservation
                {
                    ID = 6,
                    Time = new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6517),
                    State = ReservationState.Done,
                    PlacePriceId = 3,
                    UserID = "6",
                    SerialNumber = 70000004
                },
                new Reservation
                {
                    ID = 7,
                    Time = new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6530),
                    State = ReservationState.Running,
                    PlacePriceId = 4,
                    UserID = "7",
                    SerialNumber = 70000005
                },
                new Reservation
                {
                    ID = 8,
                    Time = new DateTime(2024, 3, 9, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6543),
                    State = ReservationState.Running,
                    PlacePriceId = 4,
                    UserID = "8",
                    SerialNumber = 70000006
                },
                new Reservation
                {
                    ID = 9,
                    Time = new DateTime(2024, 3, 10, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6556),
                    State = ReservationState.Running,
                    PlacePriceId = 5,
                    UserID = "9",
                    SerialNumber = 70000007
                },
                new Reservation
                {
                    ID = 10,
                    Time = new DateTime(2024, 3, 11, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6569),
                    State = ReservationState.Done,
                    PlacePriceId = 5,
                    UserID = "10",
                    SerialNumber = 70000008
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
                    PlaceType = PlaceType.Clinic // Assuming place type, adjust accordingly
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    PlaceType = PlaceType.Clinic
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
                    TestLabID = 1, // Assuming test lab ID, adjust accordingly
                    LabID = 1, // Assuming lab ID, adjust accordingly
                    Price = 100.00, // Assuming price, adjust accordingly
                    Description = "Description of test lab 1"
                },
                new TestLab
                {
                    ID = 2,
                    TestLabID = 2, // Assuming test lab ID, adjust accordingly
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
                    TestLabID = 3
                },
                new TestLab
                {
                    ID = 4,
                    Description = "Description of test lab 4",
                    LabID = 4,
                    Price = 250.0,
                    TestLabID = 4
                },
                new TestLab
                {
                    ID = 5,
                    Description = "Description of test lab 5",
                    LabID = 5,
                    Price = 300.0,
                    TestLabID = 5
                },
                new TestLab
                {
                    ID = 6,
                    Description = "Description of test lab 6",
                    LabID = 6,
                    Price = 350.0,
                    TestLabID = 6
                },
                new TestLab
                {
                    ID = 7,
                    Description = "Description of test lab 7",
                    LabID = 7,
                    Price = 400.0,
                    TestLabID = 7
                },
                new TestLab
                {
                    ID = 8,
                    Description = "Description of test lab 8",
                    LabID = 8,
                    Price = 450.0,
                    TestLabID = 8
                },
                new TestLab
                {
                    ID = 9,
                    Description = "Description of test lab 9",
                    LabID = 9,
                    Price = 500.0,
                    TestLabID = 9
                },
                new TestLab
                {
                    ID = 10,
                    Description = "Description of test lab 10",
                    LabID = 10,
                    Price = 550.0,
                    TestLabID = 10
                });
            modelBuilder.Entity<Test>().HasData(
                new Test
                {
                    ID = 1,
                    Name = "Blood Test"
                },
                new Test
                {
                    ID = 2,
                    Name = "Urinalysis"
                },
                new Test
                {
                    ID = 3,
                    Name = "MRI Scan"
                },
                new Test
                {
                    ID = 4,
                    Name = "X-ray Imaging"
                },
                new Test
                {
                    ID = 5,
                    Name = "Ultrasound Examination"
                },
                new Test
                {
                    ID = 6,
                    Name = "CT Scan"
                },
                new Test
                {
                    ID = 7,
                    Name = "EKG Test"
                },
                new Test
                {
                    ID = 8,
                    Name = "Colonoscopy"
                },
                new Test
                {
                    ID = 9,
                    Name = "Endoscopy"
                },
                new Test
                {
                    ID = 10,
                    Name = "Biopsy"
                });

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

            #endregion

            #region Configs
            new ClinicConfig().Configure(modelBuilder.Entity<Clinic>());
            new PlacePriceConfig().Configure(modelBuilder.Entity<PlacePrice>());
            new DepartmentConfig().Configure(modelBuilder.Entity<Department>());
            new DocumentConfig().Configure(modelBuilder.Entity<Document>());
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
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #region DbSets
        public DbSet<Clinic> clinics { get; set; }
        public DbSet<PlacePrice> placePrice { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Document> documents { get; set; }
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
