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
    public class Context: IdentityDbContext<User>
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configs
            new ClinicConfig().Configure(modelBuilder.Entity<Clinic>());
            new ClinicPriceConfig().Configure(modelBuilder.Entity<ClinicPrice>());
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
            new UserConfig().Configure(modelBuilder.Entity<User>()); 
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #region DbSets
        public DbSet<Clinic> clinics { get; set; }
        public DbSet<ClinicPrice> clinicsPrice { get; set; }
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
        public DbSet<User> users { get; set; } 
        #endregion
    }
}
