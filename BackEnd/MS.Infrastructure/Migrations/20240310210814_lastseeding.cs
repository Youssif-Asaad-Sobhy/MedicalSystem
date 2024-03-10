using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class lastseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a43a54a0-476f-4c8a-a198-892ef7833059", "a8d0cf7a-1f1c-47e0-b59c-6ec7e46a31f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8150ad05-cc03-418a-9e33-d8b8bdfc041e", "6689d3f6-644c-467a-ba08-4285c46b9c48" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NID", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, new DateTime(1982, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c985424-f94e-4fe9-998b-7bf5cf090d18", null, false, "Female", false, null, "1122334455", "Laila", "LAILA@EXAMPLE.COM", "LAILA4040", null, null, false, "c9e5fadb-bfa6-4a04-b481-5f68fb641af4", false, "LAILA4040" },
                    { "3", 0, new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "dcfce854-d498-4a24-aae5-c5444139b569", null, false, "Male", false, null, "9876543210", "Mohammed", "MOHAMMED@EXAMPLE.COM", "MOHAMMED123", null, null, false, "bc42c9f2-ccee-4315-8a79-e2a4d87f1dee", false, "MOHAMMED123" },
                    { "4", 0, new DateTime(1995, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ea813a6e-2308-4602-8d92-23bdefac32ce", null, false, "Female", false, null, "0123456789", "Aisha", "AISHA@EXAMPLE.COM", "AISHA321", null, null, false, "e69263e7-f818-4cf2-907c-ec6190a3cbcf", false, "AISHA321" },
                    { "5", 0, new DateTime(1978, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "54d4927b-5a87-4bee-b299-9ddc2e683a4c", null, false, "Male", false, null, "1122334455", "Ahmad", "AHMAD@EXAMPLE.COM", "AHMAD567", null, null, false, "3ca6ee1f-5c0a-4180-ae1a-13747fe7a6a7", false, "AHMAD567" },
                    { "6", 0, new DateTime(1989, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6e1e489-e148-4d19-ab33-3d769106a150", null, false, "Female", false, null, "3344556677", "Aya", "AYA@EXAMPLE.COM", "AYA789", null, null, false, "b1328d4a-eec0-43be-b381-2eba09aceb9e", false, "AYA789" },
                    { "7", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "9646c465-6bae-4b1c-922a-48215dc439b5", null, false, "Male", false, null, "5544332211", "Omar", "OMAR@EXAMPLE.COM", "OMAR101", null, null, false, "1adeb917-d8d0-4cd5-8699-56d46b0e136e", false, "OMAR101" },
                    { "8", 0, new DateTime(1980, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "f41040be-aea9-4b0b-94bf-5e1477764b5a", null, false, "Female", false, null, "7788990011", "Sara", "SARA@EXAMPLE.COM", "SARA2022", null, null, false, "973e2658-6e23-4a27-b36f-9fcf7acf9b0b", false, "SARA2022" },
                    { "9", 0, new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3eee4c70-d74f-4612-a865-6702c7e33eaa", null, false, "Male", false, null, "6677889900", "Ali", "ALI@EXAMPLE.COM", "ALI3030", null, null, false, "85854bf7-327b-49b5-972c-e61baba52a40", false, "ALI3030" }
                });

            migrationBuilder.InsertData(
                table: "clinics",
                columns: new[] { "ID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 3, 3, "Mediplus" },
                    { 4, 4, "HealthLine" }
                });

            migrationBuilder.InsertData(
                table: "equipments",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Ultrasound machine for medical imaging", "Ultrasound Machine" },
                    { 4, "CT scanner for detailed cross-sectional images", "CT Scanner" },
                    { 5, "PET scanner for functional imaging", "PET Scanner" },
                    { 6, "Mammography machine for breast imaging", "Mammography Machine" },
                    { 7, "Fluoroscopy machine for real-time imaging", "Fluoroscopy Machine" },
                    { 8, "DEXA scanner for bone density measurement", "DEXA Scanner" },
                    { 9, "Gamma camera for nuclear medicine imaging", "Gamma Camera" },
                    { 10, "Endoscopy system for internal imaging", "Endoscopy System" }
                });

            migrationBuilder.InsertData(
                table: "hospitals",
                columns: new[] { "ID", "City", "Country", "Government", "Name", "Phone", "Type" },
                values: new object[,]
                {
                    { 3, "Los Angeles", "United States", "Private Hospital", "Cedars-Sinai Medical Center", "+1-310-423-3277", 1 },
                    { 4, "Chicago", "United States", "University Hospital", "Northwestern Memorial Hospital", "+1-312-926-2000", 0 },
                    { 5, "Houston", "United States", "Veterans Hospital", "Michael E. DeBakey VA Medical Center", "+1-713-791-1414", 1 },
                    { 6, "Philadelphia", "United States", "Children's Hospital", "Children's Hospital of Philadelphia", "+1-215-590-1000", 0 },
                    { 7, "Phoenix", "United States", "Research Hospital", "Mayo Clinic Hospital", "+1-480-515-6296", 1 },
                    { 8, "San Antonio", "United States", "Teaching Hospital", "University Hospital - University of Texas Health Science Center", "+1-210-358-4000", 0 },
                    { 9, "San Diego", "United States", "Community Hospital", "Scripps Memorial Hospital La Jolla", "+1-858-626-4123", 1 },
                    { 10, "Dallas", "United States", "Children's Hospital", "Children's Health - Children's Medical Center Dallas", "+1-214-456-7000", 0 }
                });

            migrationBuilder.InsertData(
                table: "medicines",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 3, "Ibuprofen" },
                    { 4, "Acetaminophen" },
                    { 5, "Omeprazole" },
                    { 6, "Lisinopril" },
                    { 7, "Metformin" },
                    { 8, "Simvastatin" },
                    { 9, "Atorvastatin" },
                    { 10, "Levothyroxine" }
                });

            migrationBuilder.UpdateData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 3,
                column: "PlaceType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 9, 23, 8, 11, 290, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 8, 23, 8, 11, 290, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 3, "Description of report 3", "1", new DateTime(2024, 3, 1, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6357), "1" },
                    { 4, "Description of report 4", "2", new DateTime(2024, 3, 2, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6431), "2" }
                });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "SerialNumber", "Time" },
                values: new object[] { 45165153, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "SerialNumber", "Time" },
                values: new object[] { 543864963, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.InsertData(
                table: "shifts",
                columns: new[] { "ID", "EndTime", "EntityID", "Name", "PlaceType", "StartTime" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 4, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 6, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 7, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 8, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 9, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 10, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "tests",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 3, "MRI Scan" },
                    { 4, "X-ray Imaging" },
                    { 5, "Ultrasound Examination" },
                    { 6, "CT Scan" },
                    { 7, "EKG Test" },
                    { 8, "Colonoscopy" },
                    { 9, "Endoscopy" },
                    { 10, "Biopsy" }
                });

            migrationBuilder.InsertData(
                table: "types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 3, "Type 3" },
                    { 4, "Type 4" },
                    { 5, "Type 5" },
                    { 6, "Type 6" },
                    { 7, "Type 7" },
                    { 8, "Type 8" },
                    { 9, "Type 9" },
                    { 10, "Type 10" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "ID", "HospitalID", "Name" },
                values: new object[,]
                {
                    { 5, 3, "Dermatology" },
                    { 6, 3, "Endocrinology" },
                    { 7, 4, "Gastroenterology" },
                    { 8, 4, "Hematology" },
                    { 9, 5, "Immunology" },
                    { 10, 5, "Nephrology" }
                });

            migrationBuilder.InsertData(
                table: "documents",
                columns: new[] { "ID", "Content", "ReportID" },
                values: new object[,]
                {
                    { 3, new byte[0], 3 },
                    { 4, new byte[0], 4 }
                });

            migrationBuilder.InsertData(
                table: "labs",
                columns: new[] { "ID", "HospitalID", "Name", "Type" },
                values: new object[,]
                {
                    { 3, 3, "Chemistry Lab", 1 },
                    { 4, 4, "Hematology Lab", 0 },
                    { 5, 5, "Immunology Lab", 0 },
                    { 6, 6, "Genetics Lab", 0 },
                    { 7, 7, "Histology Lab", 1 },
                    { 8, 8, "Virology Lab", 0 },
                    { 9, 9, "Toxicology Lab", 1 },
                    { 10, 10, "Molecular Biology Lab", 1 }
                });

            migrationBuilder.InsertData(
                table: "medicinesType",
                columns: new[] { "ID", "Description", "ExpirationDate", "MedicineID", "SideEffects", "TypeID", "Warning" },
                values: new object[,]
                {
                    { 3, "Antacid", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Relieves heartburn", 3, "Avoid taking other medications within 2 hours" },
                    { 4, "Antihistamine", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "May cause drowsiness", 4, "Avoid alcohol while taking" },
                    { 5, "Anti-inflammatory", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Take with food or milk", 5, "Not recommended for long-term use" },
                    { 6, "Antidepressant", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "May take several weeks to see effects", 6, "Do not abruptly discontinue" },
                    { 7, "Anticoagulant", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Increased risk of bleeding", 7, "Regular monitoring required" },
                    { 8, "Antidiabetic", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Monitor blood sugar levels regularly", 8, "Report any unusual symptoms to doctor" },
                    { 9, "Antiemetic", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "May cause drowsiness or dizziness", 9, "Avoid driving or operating machinery" },
                    { 10, "Antifungal", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Apply as directed to affected area", 10, "Complete full course of treatment" }
                });

            migrationBuilder.InsertData(
                table: "pharmacies",
                columns: new[] { "ID", "HospitalID", "Name" },
                values: new object[,]
                {
                    { 3, 3, "Rite Aid" },
                    { 4, 4, "Walmart Pharmacy" },
                    { 5, 5, "Target Pharmacy" },
                    { 6, 6, "Kroger Pharmacy" },
                    { 7, 7, "Costco Pharmacy" },
                    { 8, 8, "Publix Pharmacy" },
                    { 9, 9, "Wal-Mart Pharmacy" },
                    { 10, 10, "Safeway Pharmacy" }
                });

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 5, "Description of report 5", "3", new DateTime(2024, 3, 3, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6505), "3" },
                    { 6, "Description of report 6", "4", new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6579), "4" },
                    { 7, "Description of report 7", "5", new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6653), "5" },
                    { 8, "Description of report 8", "6", new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6727), "6" },
                    { 9, "Description of report 9", "7", new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6801), "7" },
                    { 10, "Description of report 10", "8", new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6875), "8" }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "ID", "ClinicID", "LabID", "PlacePriceId", "SerialNumber", "State", "Time", "UserID" },
                values: new object[,]
                {
                    { 5, null, null, 3, 70000003, 0, new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6504), "5" },
                    { 6, null, null, 3, 70000004, 0, new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6517), "6" }
                });

            migrationBuilder.InsertData(
                table: "clinics",
                columns: new[] { "ID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 5, 5, "MediCare" },
                    { 6, 6, "Wellness Pharmacy" },
                    { 7, 7, "CarePlus" },
                    { 8, 8, "MediPharm" },
                    { 9, 9, "MediCo" },
                    { 10, 10, "PharmaCare" }
                });

            migrationBuilder.InsertData(
                table: "documents",
                columns: new[] { "ID", "Content", "ReportID" },
                values: new object[,]
                {
                    { 5, new byte[0], 5 },
                    { 6, new byte[0], 6 },
                    { 7, new byte[0], 7 },
                    { 8, new byte[0], 8 },
                    { 9, new byte[0], 9 },
                    { 10, new byte[0], 10 }
                });

            migrationBuilder.InsertData(
                table: "pharmacyMedicines",
                columns: new[] { "ID", "Amount", "MedicineTypeID", "PharmacyID", "Price" },
                values: new object[,]
                {
                    { 3, 75, 3, 3, 15.49 },
                    { 4, 200, 4, 4, 8.75 },
                    { 5, 150, 5, 5, 12.25 },
                    { 6, 120, 6, 6, 9.9900000000000002 },
                    { 7, 80, 7, 7, 17.5 },
                    { 8, 90, 8, 8, 14.75 },
                    { 9, 110, 9, 9, 11.25 },
                    { 10, 70, 10, 10, 19.989999999999998 }
                });

            migrationBuilder.InsertData(
                table: "placeEquipments",
                columns: new[] { "ID", "EntityID", "EquipmentID", "PlaceType" },
                values: new object[,]
                {
                    { 3, 3, 3, 0 },
                    { 4, 4, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "placePrice",
                columns: new[] { "ID", "Name", "PlaceID", "PlaceType", "Price" },
                values: new object[,]
                {
                    { 2, "X-Beta", 3, 2, 419.99000000000001 },
                    { 4, "MRI", 4, 1, 599.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "placeShifts",
                columns: new[] { "ID", "EntityID", "PlaceType", "ShiftID" },
                values: new object[,]
                {
                    { 3, 3, 1, 2 },
                    { 4, 4, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "reportsMedicines",
                columns: new[] { "ID", "MedicineTypeID", "ReportID" },
                values: new object[,]
                {
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "testLabs",
                columns: new[] { "ID", "Description", "LabID", "Price", "TestLabID" },
                values: new object[,]
                {
                    { 3, "Description of test lab 3", 3, 200.0, 3 },
                    { 4, "Description of test lab 4", 4, 250.0, 4 },
                    { 5, "Description of test lab 5", 5, 300.0, 5 },
                    { 6, "Description of test lab 6", 6, 350.0, 6 },
                    { 7, "Description of test lab 7", 7, 400.0, 7 },
                    { 8, "Description of test lab 8", 8, 450.0, 8 },
                    { 9, "Description of test lab 9", 9, 500.0, 9 },
                    { 10, "Description of test lab 10", 10, 550.0, 10 }
                });

            migrationBuilder.InsertData(
                table: "placeEquipments",
                columns: new[] { "ID", "EntityID", "EquipmentID", "PlaceType" },
                values: new object[,]
                {
                    { 5, 5, 5, 0 },
                    { 6, 6, 6, 1 },
                    { 7, 7, 7, 0 },
                    { 8, 8, 8, 1 },
                    { 9, 9, 9, 0 },
                    { 10, 10, 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "placePrice",
                columns: new[] { "ID", "Name", "PlaceID", "PlaceType", "Price" },
                values: new object[,]
                {
                    { 5, "CT Scan", 5, 0, 799.99000000000001 },
                    { 6, "Ultrasound", 6, 0, 499.99000000000001 },
                    { 7, "PET Scan", 7, 1, 1199.99 },
                    { 8, "Mammography", 8, 0, 299.99000000000001 },
                    { 9, "Fluoroscopy", 9, 1, 699.99000000000001 },
                    { 10, "DEXA Scan", 10, 2, 249.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "placeShifts",
                columns: new[] { "ID", "EntityID", "PlaceType", "ShiftID" },
                values: new object[,]
                {
                    { 5, 5, 0, 2 },
                    { 6, 6, 0, 1 },
                    { 7, 7, 0, 2 },
                    { 8, 8, 1, 1 },
                    { 9, 9, 0, 2 },
                    { 10, 10, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "ID", "ClinicID", "LabID", "PlacePriceId", "SerialNumber", "State", "Time", "UserID" },
                values: new object[,]
                {
                    { 3, null, null, 2, 70000001, 0, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6478), "3" },
                    { 4, null, null, 2, 70000002, 0, new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6491), "4" },
                    { 7, null, null, 4, 70000005, 1, new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6530), "7" },
                    { 8, null, null, 4, 70000006, 1, new DateTime(2024, 3, 9, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6543), "8" },
                    { 9, null, null, 5, 70000007, 1, new DateTime(2024, 3, 10, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6556), "9" },
                    { 10, null, null, 5, 70000008, 0, new DateTime(2024, 3, 11, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6569), "10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "documents",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "pharmacyMedicines",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "placeEquipments",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "placeShifts",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "reportsMedicines",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "shifts",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "testLabs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "equipments",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "medicinesType",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "pharmacies",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "labs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "medicines",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "types",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hospitals",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2dd81328-68be-4e2f-ae3c-f98b9edb6fe7", "7f542e47-e6d5-46e3-837e-b73070df5e71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "697bc294-eccc-4aca-86bf-b7f5bfa25dbb", "c38ba1a2-8f41-4255-9235-0074bc16ea81" });

            migrationBuilder.UpdateData(
                table: "placePrice",
                keyColumn: "ID",
                keyValue: 3,
                column: "PlaceType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 9, 21, 51, 30, 990, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 8, 21, 51, 30, 990, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "SerialNumber", "Time" },
                values: new object[] { 0, new DateTime(2024, 3, 11, 21, 51, 30, 990, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "SerialNumber", "Time" },
                values: new object[] { 0, new DateTime(2024, 3, 12, 21, 51, 30, 990, DateTimeKind.Local).AddTicks(1728) });
        }
    }
}
