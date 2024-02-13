using Microsoft.EntityFrameworkCore.Migrations;
using MS.Data.Enums;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seed ApplicationUser
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount", "Name", "NID", "Gender", "BirthDate" },
                values: new object[,]
                {
                    { "user1@example.com", "USER1@EXAMPLE.COM", "user1@example.com", "USER1@EXAMPLE.COM", true, "", "", "", false, false, false, 0, "User 1", "123456789", "Male", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "user2@example.com", "USER2@EXAMPLE.COM", "user2@example.com", "USER2@EXAMPLE.COM", true, "", "", "", false, false, false, 0, "User 2", "987654321", "Female", new DateTime(1985, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            //// Seed Clinic
            //migrationBuilder.InsertData(
            //    table: "Clinics",
            //    columns: new[] { "Name", "DepartmentID" },
            //    values: new object[,]
            //    {
            //        { "Clinic 1", 1 },
            //        { "Clinic 2", 2 }
            //    });

            //// Seed ClinicPrice
            //migrationBuilder.InsertData(
            //    table: "ClinicPrices",
            //    columns: new[] { "Name", "Price", "ClinicID" },
            //    values: new object[,]
            //    {
            //        { "Price 1", 50.0, 1 },
            //        { "Price 2", 75.0, 2 }
            //    });

            //// Seed Department
            //migrationBuilder.InsertData(
            //    table: "Departments",
            //    columns: new[] { "Name", "HospitalID" },
            //    values: new object[,]
            //    {
            //        { "Department 1", 1 },
            //        { "Department 2", 2 }
            //    });

            //// Seed EntityAuth
            //migrationBuilder.InsertData(
            //    table: "EntityAuths",
            //    columns: new[] { "UserID", "PlaceType", "EntityID" },
            //    values: new object[,]
            //    {
            //        { 1, PlaceType.Clinic, 1 },
            //        { 2, PlaceType.Clinic, 2 }
            //    });
            //// Seed Equipment
            //migrationBuilder.InsertData(
            //    table: "Equipments",
            //    columns: new[] { "Name", "Description" },
            //    values: new object[,]
            //    {
            //{ "Equipment 1", "Description of Equipment 1" },
            //{ "Equipment 2", "Description of Equipment 2" }
            //    });
            //// Seed Hospital
            //migrationBuilder.InsertData(
            //    table: "Hospitals",
            //    columns: new[] { "Name", "Phone", "Government", "City", "Country", "Type" },
            //    values: new object[,]
            //    {
            //{ "Hospital 1", "123-456-7890", "Government 1", "City 1", "Country 1", HospitalType.Public },
            //{ "Hospital 2", "987-654-3210", "Government 2", "City 2", "Country 2", HospitalType.Private }
            //    });
            //// Seed Lab
            //migrationBuilder.InsertData(
            //    table: "Labs",
            //    columns: new[] { "Name", "Type", "HospitalID" },
            //    values: new object[,]
            //    {
            //        { "Lab 1", (int)LabType.Lab, 1 },
            //        { "Lab 2", (int)LabType.XRay, 2 }
            //    });

            //// Seed Medicine
            //migrationBuilder.InsertData(
            //    table: "Medicines",
            //    columns: new[] { "Name" },
            //    values: new object[,]
            //    {
            //{ "Medicine 1" },
            //{ "Medicine 2" }
            //    });
            //// Seed MedicineType
            //migrationBuilder.InsertData(
            //    table: "MedicineTypes",
            //    columns: new[] { "MedicineID", "TypeID", "Description", "SideEffects", "Warning", "ExpirationDate" },
            //    values: new object[,]
            //    {
            //{ 1, 1, "Description of MedicineType 1", "Side effects of MedicineType 1", "Warning for MedicineType 1", DateTime.Now.AddDays(30) },
            //{ 1, 2, "Description of MedicineType 2", "Side effects of MedicineType 2", "Warning for MedicineType 2", DateTime.Now.AddDays(60) },
            //{ 2, 1, "Description of MedicineType 3", "Side effects of MedicineType 3", "Warning for MedicineType 3", DateTime.Now.AddDays(90) }
            //    });
            //// Seed Pharmacy
            //migrationBuilder.InsertData(
            //    table: "Pharmacies",
            //    columns: new[] { "Name", "HospitalID" },
            //    values: new object[,]
            //    {
            //{ "Pharmacy 1", 1 },
            //{ "Pharmacy 2", 2 }
            //    });
            //// Seed PharmacyMedicine
            //migrationBuilder.InsertData(
            //    table: "PharmacyMedicines",
            //    columns: new[] { "PharmacyID", "MedicineTypeID", "Amount", "Price" },
            //    values: new object[,]
            //    {
            //{ 1, 1, 100, 10.5 },
            //{ 1, 2, 50, 20.0 },
            //{ 2, 1, 75, 15.0 },
            //{ 2, 2, 60, 25.0 }
            //    });
            //// Seed PlaceEquipment
            //migrationBuilder.InsertData(
            //    table: "PlaceEquipments",
            //    columns: new[] { "EquipmentID", "EntityID", "PlaceType" },
            //    values: new object[,]
            //    {
            //{ 1, 1, PlaceType.Clinic },
            //{ 2, 2, PlaceType.Pharmacy }
            //    });
            //// Seed PlaceShift
            //migrationBuilder.InsertData(
            //    table: "PlaceShifts",
            //    columns: new[] { "EntityID", "PlaceType", "ShiftID" },
            //    values: new object[,]
            //    {
            //        { 1, PlaceType.Clinic, 1 },
            //        { 2, PlaceType.Pharmacy, 2 }
            //    });
            //// Seed Report
            //migrationBuilder.InsertData(
            //    table: "Reports",
            //    columns: new[] { "Time", "Description", "UserID", "DoctorID" },
            //    values: new object[,]
            //    {
            //        { DateTime.Now.AddDays(-7), "Description of Report 1", 1, 1 },
            //        { DateTime.Now.AddDays(-5), "Description of Report 2", 2, 2 }
            //    });
            //// Seed ReportMedicine
            //migrationBuilder.InsertData(
            //    table: "ReportMedicines",
            //    columns: new[] { "ReportID", "MedicineTypeID" },
            //    values: new object[,]
            //    {
            //        { 1, 1 },
            //        { 1, 2 },
            //        { 2, 2 }
            //    });
            //// Seed Reservation
            //migrationBuilder.InsertData(
            //    table: "Reservations",
            //    columns: new[] { "Time", "State", "PlaceType", "EntityID", "Price", "UserID" },
            //    values: new object[,]
            //    {
            //        { DateTime.Now.AddDays(1), ReservationState.Done, PlaceType.Clinic, 1, 50.0, "user_id_1" },
            //        { DateTime.Now.AddDays(2), ReservationState.Runing, PlaceType.Lab, 2, 75.0, "user_id_2" }
            //    });
            //// Seed Shift
            //migrationBuilder.InsertData(
            //    table: "Shifts",
            //    columns: new[] { "Name", "StartTime", "EndTime", "EntityID", "PlaceType" },
            //    values: new object[,]
            //    {
            //        { "Morning Shift", DateTime.Parse("08:00"), DateTime.Parse("12:00"), 1, PlaceType.Clinic },
            //        { "Afternoon Shift", DateTime.Parse("12:00"), DateTime.Parse("16:00"), 2, PlaceType.Lab }
            //    });
            //// Seed Test
            //migrationBuilder.InsertData(
            //    table: "Tests",
            //    columns: new[] { "Name" },
            //    values: new object[,]
            //    {
            //        { "Test 1" },
            //        { "Test 2" }
            //    });
            //// Seed TestLab
            //migrationBuilder.InsertData(
            //    table: "TestLabs",
            //    columns: new[] { "TestLabID", "LabID", "Price", "Description" },
            //    values: new object[,]
            //    {
            //        { 1, 1, 50.0, "Description for TestLab 1" },
            //        { 2, 2, 75.0, "Description for TestLab 2" }
            //    });
            //// Seed Types
            //migrationBuilder.InsertData(
            //    table: "Types",
            //    columns: new[] { "Name" },
            //    values: new object[,]
            //    {
            //        { "Type 1" },
            //        { "Type 2" }
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove seeded data for ApplicationUser
            migrationBuilder.Sql("DELETE FROM AspNetUsers");

            //// Remove seeded data for Clinic, ClinicPrice, Department (add appropriate delete statements)
            //migrationBuilder.Sql("DELETE FROM ClinicPrices");
            //migrationBuilder.Sql("DELETE FROM Clinics");
            //migrationBuilder.Sql("DELETE FROM Departments");

            //// Remove seeded data for EntityAuth
            //migrationBuilder.Sql("DELETE FROM EntityAuths");
            //// Remove seeded data for Equipment
            //migrationBuilder.Sql("DELETE FROM Equipments");
            //// Remove seeded data for Hospital
            //migrationBuilder.Sql("DELETE FROM Hospitals");
            //// Remove seeded data for Lab
            //migrationBuilder.Sql("DELETE FROM Labs");
            //// Remove seeded data for Medicine
            //migrationBuilder.Sql("DELETE FROM Medicines");
            //// Remove seeded data for MedicineType
            //migrationBuilder.Sql("DELETE FROM MedicineTypes");
            //// Remove seeded data for Pharmacy
            //migrationBuilder.Sql("DELETE FROM Pharmacies");
            //// Remove seeded data for PharmacyMedicine
            //migrationBuilder.Sql("DELETE FROM PharmacyMedicines");
            //// Remove seeded data for PlaceEquipment
            //migrationBuilder.Sql("DELETE FROM PlaceEquipments");
            //// Remove seeded data for PlaceShift
            //migrationBuilder.Sql("DELETE FROM PlaceShifts");
            //// Remove seeded data for Report
            //migrationBuilder.Sql("DELETE FROM Reports");
            //// Remove seeded data for ReportMedicine
            //migrationBuilder.Sql("DELETE FROM ReportMedicines");
            //// Remove seeded data for Reservation
            //migrationBuilder.Sql("DELETE FROM Reservations");
            //// Remove seeded data for Shift
            //migrationBuilder.Sql("DELETE FROM Shifts");
            //// Remove seeded data for Test
            //migrationBuilder.Sql("DELETE FROM Tests");
            //// Remove seeded data for TestLab
            //migrationBuilder.Sql("DELETE FROM TestLabs");
            //// Remove seeded data for Types
            //migrationBuilder.Sql("DELETE FROM Types");


        }
    }
}
