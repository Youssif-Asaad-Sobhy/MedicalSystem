using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class advanced : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NID", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                        { "3", 0, new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ec6a4cf4-6954-4a11-bb6e-bcbe58635032", null, false, "Male", false, null, "9876543210", "Mohammed", "MOHAMMED@EXAMPLE.COM", "MOHAMMED123", null, null, false, "8f7f23b1-98f1-445a-bfea-f2c4eb7b26c6", false, "Mohammed123" },
                        { "4", 0, new DateTime(1995, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "f16cfd3d-0452-4972-8d1a-aa3cb87bdfed", null, false, "Female", false, null, "0123456789", "Aisha", "AISHA@EXAMPLE.COM", "AISHA321", null, null, false, "c9877dfc-2c2d-49a3-9d4c-b62bcb5fd775", false, "Aisha321" },
                        { "5", 0, new DateTime(1978, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "e42c00a2-5a80-458b-8cd4-8a3e0e5c7249", null, false, "Male", false, null, "1122334455", "Ahmad", "AHMAD@EXAMPLE.COM", "AHMAD567", null, null, false, "1fd314a1-2880-4fc1-8365-4e95fc3b2794", false, "Ahmad567" },
                        { "6", 0, new DateTime(1989, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "a16b2c0b-6b4c-499c-9bb0-72e6d6f3af0e", null, false, "Female", false, null, "3344556677", "Aya", "AYA@EXAMPLE.COM", "AYA789", null, null, false, "0d4824d1-b4f3-42d8-afe2-74c7992dd42b", false, "Aya789" },
                        { "7", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "f69d11a0-ea7b-4f3c-a2dc-018e10a31462", null, false, "Male", false, null, "5544332211", "Omar", "OMAR@EXAMPLE.COM", "OMAR101", null, null, false, "83b3b987-67b9-43d4-b7b7-89e2f59f3f65", false, "Omar101" },
                        { "8", 0, new DateTime(1980, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "a8df2ac3-9d1a-44b1-8c0e-621d14a83d02", null, false, "Female", false, null, "7788990011", "Sara", "SARA@EXAMPLE.COM", "SARA2022", null, null, false, "b8316ac7-c436-4c61-b67f-944a6bc45780", false, "Sara2022" },
                        { "9", 0, new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ef7b0c95-9cfb-48e9-b68a-89374022581c", null, false, "Male", false, null, "6677889900", "Ali", "ALI@EXAMPLE.COM", "ALI3030", null, null, false, "b287a058-9ab7-4433-8df1-af95d5e94336", false, "Ali3030" },
                        { "10", 0, new DateTime(1982, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6aee63ad-0838-4ad8-8941-632d37c5f539", null, false, "Female", false, null, "1122334455", "Laila", "LAILA@EXAMPLE.COM", "LAILA4040", null, null, false, "a1558713-8dc9-49cf-9e25-68d26fbdff0a", false, "Laila4040" }
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
                    { 10, "Endoscopy system for internal imaging", "Endoscopy System" },
                });

            migrationBuilder.InsertData(
                table: "hospitals",
                columns: new[] { "ID", "City", "Country", "Government", "Name", "Phone", "Type" },
                values: new object[,]
                {
                    { 3, "Los Angeles", "United States", "Private Hospital", "Cedars-Sinai Medical Center", "+1-310-423-3277", 0 },
                    { 4, "Chicago", "United States", "University Hospital", "Northwestern Memorial Hospital", "+1-312-926-2000", 1 },
                    { 5, "Houston", "United States", "Veterans Hospital", "Michael E. DeBakey VA Medical Center", "+1-713-791-1414", 0 },
                    { 6, "Philadelphia", "United States", "Children's Hospital", "Children's Hospital of Philadelphia", "+1-215-590-1000", 1 },
                    { 7, "Phoenix", "United States", "Research Hospital", "Mayo Clinic Hospital", "+1-480-515-6296", 0 },
                    { 8, "San Antonio", "United States", "Teaching Hospital", "University Hospital - University of Texas Health Science Center", "+1-210-358-4000", 1 },
                    { 9, "San Diego", "United States", "Community Hospital", "Scripps Memorial Hospital La Jolla", "+1-858-626-4123", 0 },
                    { 10, "Dallas", "United States", "Children's Hospital", "Children's Health - Children's Medical Center Dallas", "+1-214-456-7000", 1 },
                    { 11, "San Jose", "United States", "General Hospital", "Santa Clara Valley Medical Center", "+1-408-885-5000", 0 },
                    { 12, "Austin", "United States", "Psychiatric Hospital", "Austin State Hospital", "+1-512-452-0381", 1 }
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
                    { 9, "Atorvastatin"},
                    { 10, "Levothyroxine" },
                    { 11, "Metoprolol" },
                    { 12, "Amlodipine" }
                });

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 3, "Description of report 3", "3", new DateTime(2024, 3, 1, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6357), "1" },
                    { 4, "Description of report 4", "4", new DateTime(2024, 3, 2, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6431), "2" },
                    { 5, "Description of report 5", "5", new DateTime(2024, 3, 3, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6505), "3" },
                    { 6, "Description of report 6", "6", new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6579), "4" },
                    { 7, "Description of report 7", "7", new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6653), "5" },
                    { 8, "Description of report 8", "8", new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6727), "6" },
                    { 9, "Description of report 9", "9", new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6801), "7" },
                    { 10, "Description of report 10", "10", new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6875), "8" },

                });

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
                    { 4, new byte[0], 4 },
                    { 5, new byte[0], 5 },
                    { 6, new byte[0], 6 },
                    { 7, new byte[0], 7 },
                    { 8, new byte[0], 8 },
                    { 9, new byte[0], 9 },
                    { 10, new byte[0], 10 }
                });

            migrationBuilder.InsertData(
                table: "labs",
                columns: new[] { "ID", "HospitalID", "Name", "Type" },
                values: new object[,]
                {
                    { 3, 3, "Chemistry Lab", 1 },
                    { 4, 4, "Hematology Lab", 0 },
                    { 5, 5, "Immunology Lab", 1 },
                    { 6, 6, "Genetics Lab", 0 },
                    { 7, 7, "Histology Lab", 1 },
                    { 8, 8, "Virology Lab", 0 },
                    { 9, 9, "Toxicology Lab", 1 },
                    { 10, 10, "Molecular Biology Lab", 0 }
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
                table: "clinics",
                columns: new[] { "ID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 3, 3, "Mediplus" },
                    { 4, 4, "HealthLine" },
                    { 5, 5, "MediCare" },
                    { 6, 6, "Wellness Pharmacy" },
                    { 7, 7, "CarePlus" },
                    { 8, 8, "MediPharm" },
                    { 9, 9, "MediCo" },
                    { 10, 10, "PharmaCare" }
                });

            migrationBuilder.InsertData(
                table: "pharmacyMedicines",
                columns: new[] { "ID", "Amount", "MedicineTypeID", "PharmacyID", "Price" },
                values: new object[,]
                {
                    { 3, 75, 3, 3, 15.49 },
                    { 4, 200, 4, 4, 8.75 },
                    { 5, 150, 5, 5, 12.25 },
                    { 6, 120, 6, 6, 9.99 },
                    { 7, 80, 7, 7, 17.50 },
                    { 8, 90, 8, 8, 14.75 },
                    { 9, 110, 9, 9, 11.25 },
                    { 10, 70, 10, 10, 19.99 }
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
                    { 3, 3, 3, 0 },
                    { 4, 4, 4, 1 },
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
                    { 2, "X-Beta", 3, 1, 419.99 },
                    { 4, "MRI", 4, 0, 599.99 },
                    { 5, "CT Scan", 5, 0, 799.99 },
                    { 6, "Ultrasound", 6, 0, 499.99 },
                    { 7, "PET Scan", 7, 0, 1199.99 },
                    { 8, "Mammography", 8, 1, 299.99 },
                    { 9, "Fluoroscopy", 9, 0, 699.99 },
                    { 10, "DEXA Scan", 10, 1, 249.99 }
                });

            migrationBuilder.InsertData(
                table: "placeShifts",
                columns: new[] { "ID", "EntityID", "PlaceType", "ShiftID" },
                values: new object[,]
                {
                    { 3, 3, 0, 2 },
                    { 4, 4, 1, 1 },
                    { 5, 5, 0, 2 },
                    { 6, 6, 1, 1 },
                    { 7, 7, 0, 2 },
                    { 8, 8, 1, 1 },
                    { 9, 9, 0, 2 },
                    { 10, 10, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "ID", "ClinicID", "LabID", "PlacePriceId", "State", "Time", "UserID" ,"SerialNumber" },
                values: new object[,]
                {
                    { 3, null, null, 2, 0, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6478), "3" ,70000001},
                    { 4, null, null, 2, 1, new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6491), "4" ,70000002},
                    { 5, null, null, 3, 0, new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6504), "5" ,70000003},
                    { 6, null, null, 3, 1, new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6517), "6" ,70000004},
                    { 7, null, null, 4, 0, new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6530), "7" ,70000005},
                    { 8, null, null, 4, 1, new DateTime(2024, 3, 9, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6543), "8" ,70000006},
                    { 9, null, null, 5, 0, new DateTime(2024, 3, 10, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6556), "9" ,70000007},
                    { 10, null, null, 5, 1, new DateTime(2024, 3, 11, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6569), "10" ,70000008}
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
