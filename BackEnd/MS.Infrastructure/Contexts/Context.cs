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
                    Name = "Mohamed",
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
                    Name = "Mona",
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

                });
            modelBuilder.Entity<PlacePrice>().HasData(
                new PlacePrice
                {
                    ID = 3,
                    Name = "X-ray",
                    Price = 260.40,
                    PlaceID = 1,
                },
                new PlacePrice
                {
                    ID = 1,
                    Name = "X-Alpha",
                    Price = 341.40,
                    PlaceID = 2,
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
                }
                // Add more departments as needed
            );

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
                }
                // Add more documents as needed
            );
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
                }
            // Add more equipments as needed
            );
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
     }
 // Add more hospitals as needed
 );
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
                }
            // Add more labs as needed
            );

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
                }
            // Add more pharmacy-medicine associations as needed
            );
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
                }
            // Add more place-equipment associations as needed
            );
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
                }
            // Add more reports as needed
            );
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
                }
            // Add more report-medicine associations as needed
            );
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ID = 1,
                    Time = DateTime.Now.AddDays(1), // Example date and time, adjust accordingly
                    State = ReservationState.Done, // Assuming reservation state, adjust accordingly
                    PlacePriceId = 1,
                    UserID = "1" // Assuming user ID, adjust accordingly
                },
                new Reservation
                {
                    ID = 2,
                    Time = DateTime.Now.AddDays(2), // Example date and time, adjust accordingly
                    State = ReservationState.Runing, // Assuming reservation state, adjust accordingly
                    PlacePriceId = 1,
                    UserID = "2" // Assuming user ID, adjust accordingly
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
                }
            // Add more shifts as needed
            );
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
                }
            // Add more test labs as needed
            );
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
                }
            // Add more tests as needed
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
                }
            // Add more types as needed
            );

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
