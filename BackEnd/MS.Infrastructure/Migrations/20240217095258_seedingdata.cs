using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NID", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00992da5-ca28-4d64-ab61-44744c90b798", 0, new DateTime(2002, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "bf73e652-d598-450b-91b2-dc18a7b3d44e", null, false, "male", false, null, "2636523632", "Mohamed", "MOHAMED@EXAMPLE.COM", "MOHAMEDALI123", null, null, false, "9ae810c8-31ad-43ef-92df-05d451ad17a5", false, "MohamedAli123" },
                    { "064650b8-3ce8-420b-a420-ed89cc8e0eba", 0, new DateTime(2012, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "844c8e38-3d18-469a-be95-e9192a132532", null, false, "Female", false, null, "5312523632", "Mona", "MONA@EXAMPLE.COM", "MONAOMAR123", null, null, false, "916cf95f-c695-4118-8c3b-6573bc1286d1", false, "monaomar123" }
                });

            migrationBuilder.InsertData(
                table: "equipments",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "High-field MRI machine for diagnostic imaging", "MRI Machine" },
                    { 2, "X-ray machine for radiographic imaging", "X-ray Machine" }
                });

            migrationBuilder.InsertData(
                table: "hospitals",
                columns: new[] { "ID", "City", "Country", "Government", "Name", "Phone", "Type" },
                values: new object[,]
                {
                    { 1, "New York City", "United States", "State Government", "Mount Sinai Hospital", "+1-212-241-6500", 0 },
                    { 2, "Rochester", "United States", "Local Government", "Mayo Clinic", "+1-507-284-2511", 1 }
                });

            migrationBuilder.InsertData(
                table: "medicines",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Aspirin" },
                    { 2, "Paracetamol" }
                });

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 1, "Description of report 1", 1, new DateTime(2024, 2, 16, 11, 52, 58, 420, DateTimeKind.Local).AddTicks(7883), "1" },
                    { 2, "Description of report 2", 2, new DateTime(2024, 2, 15, 11, 52, 58, 420, DateTimeKind.Local).AddTicks(7928), "2" }
                });

            migrationBuilder.InsertData(
                table: "shifts",
                columns: new[] { "ID", "EndTime", "EntityID", "Name", "PlaceType", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "tests",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Blood Test" },
                    { 2, "Urinalysis" }
                });

            migrationBuilder.InsertData(
                table: "types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Type 1" },
                    { 2, "Type 2" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "ID", "HospitalID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cardiology" },
                    { 2, 1, "Orthopedics" },
                    { 3, 2, "Neurology" },
                    { 4, 2, "Oncology" }
                });

            migrationBuilder.InsertData(
                table: "documents",
                columns: new[] { "ID", "Content", "ReportID" },
                values: new object[,]
                {
                    { 1, new byte[0], 1 },
                    { 2, new byte[0], 2 }
                });

            migrationBuilder.InsertData(
                table: "labs",
                columns: new[] { "ID", "HospitalID", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Clinical Pathology Lab", 1 },
                    { 2, 2, "Microbiology Lab", 0 }
                });

            migrationBuilder.InsertData(
                table: "medicinesType",
                columns: new[] { "ID", "Description", "ExpirationDate", "MedicineID", "SideEffects", "TypeID", "Warning" },
                values: new object[,]
                {
                    { 1, "Painkiller", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "May cause drowsiness", 1, "Do not exceed recommended dosage" },
                    { 2, "Antibiotic", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Possible nausea and diarrhea", 2, "Take with food" }
                });

            migrationBuilder.InsertData(
                table: "pharmacies",
                columns: new[] { "ID", "HospitalID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Walgreens" },
                    { 2, 2, "CVS Pharmacy" }
                });

            migrationBuilder.InsertData(
                table: "clinics",
                columns: new[] { "ID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Elzahraa" },
                    { 2, 2, "Alpha" }
                });

            migrationBuilder.InsertData(
                table: "pharmacyMedicines",
                columns: new[] { "ID", "Amount", "MedicineTypeID", "PharmacyID", "Price" },
                values: new object[,]
                {
                    { 1, 50, 1, 1, 10.99 },
                    { 2, 100, 2, 2, 5.9900000000000002 }
                });

            migrationBuilder.InsertData(
                table: "reportsMedicines",
                columns: new[] { "ID", "MedicineTypeID", "ReportID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "testLabs",
                columns: new[] { "ID", "Description", "LabID", "Price", "TestLabID" },
                values: new object[,]
                {
                    { 1, "Description of test lab 1", 1, 100.0, 1 },
                    { 2, "Description of test lab 2", 2, 150.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "clinicsPrice",
                columns: new[] { "ID", "ClinicID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "X-Alpha", 341.39999999999998 },
                    { 3, 1, "X-ray", 260.39999999999998 }
                });

            migrationBuilder.InsertData(
                table: "placeEquipments",
                columns: new[] { "ID", "EntityID", "EquipmentID", "PlaceType" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "placeShifts",
                columns: new[] { "ID", "EntityID", "PlaceType", "ShiftID" },
                values: new object[,]
                {
                    { 1, 1, 0, 1 },
                    { 2, 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "ID", "EntityID", "PlaceType", "Price", "State", "Time", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 0, 50.990000000000002, 0, new DateTime(2024, 2, 18, 11, 52, 58, 420, DateTimeKind.Local).AddTicks(7970), "1" },
                    { 2, 2, 1, 60.990000000000002, 1, new DateTime(2024, 2, 19, 11, 52, 58, 420, DateTimeKind.Local).AddTicks(7974), "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00992da5-ca28-4d64-ab61-44744c90b798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064650b8-3ce8-420b-a420-ed89cc8e0eba");

            migrationBuilder.DeleteData(
                table: "clinicsPrice",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clinicsPrice",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
