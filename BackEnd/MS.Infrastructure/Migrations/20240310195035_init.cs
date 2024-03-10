using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "equipments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "hospitals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Government = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntityID = table.Column<int>(type: "int", nullable: false),
                    PlaceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_reports_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_departments_hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "hospitals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "labs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_labs_hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "hospitals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharmacies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharmacies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_pharmacies_hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "hospitals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicinesType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SideEffects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicinesType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_medicinesType_medicines_MedicineID",
                        column: x => x.MedicineID,
                        principalTable: "medicines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_medicinesType_types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReportID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_documents_reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "reports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clinics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_clinics_departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "testLabs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestLabID = table.Column<int>(type: "int", nullable: false),
                    LabID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testLabs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_testLabs_labs_LabID",
                        column: x => x.LabID,
                        principalTable: "labs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_testLabs_tests_TestLabID",
                        column: x => x.TestLabID,
                        principalTable: "tests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharmacyMedicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacyID = table.Column<int>(type: "int", nullable: false),
                    MedicineTypeID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pharmacyMedicines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_pharmacyMedicines_medicinesType_MedicineTypeID",
                        column: x => x.MedicineTypeID,
                        principalTable: "medicinesType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pharmacyMedicines_pharmacies_PharmacyID",
                        column: x => x.PharmacyID,
                        principalTable: "pharmacies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reportsMedicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    MedicineTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportsMedicines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_reportsMedicines_medicinesType_MedicineTypeID",
                        column: x => x.MedicineTypeID,
                        principalTable: "medicinesType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reportsMedicines_reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "reports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "placeEquipments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    EntityID = table.Column<int>(type: "int", nullable: false),
                    PlaceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placeEquipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_placeEquipments_clinics_EntityID",
                        column: x => x.EntityID,
                        principalTable: "clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placeEquipments_equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_placeEquipments_labs_EntityID",
                        column: x => x.EntityID,
                        principalTable: "labs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placeEquipments_pharmacies_EntityID",
                        column: x => x.EntityID,
                        principalTable: "pharmacies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "placePrice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    PlaceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placePrice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_placePrice_clinics_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placePrice_labs_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "labs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "placeShifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityID = table.Column<int>(type: "int", nullable: false),
                    PlaceType = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placeShifts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_placeShifts_clinics_EntityID",
                        column: x => x.EntityID,
                        principalTable: "clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placeShifts_labs_EntityID",
                        column: x => x.EntityID,
                        principalTable: "labs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placeShifts_pharmacies_EntityID",
                        column: x => x.EntityID,
                        principalTable: "pharmacies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_placeShifts_shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "shifts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    PlacePriceId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClinicID = table.Column<int>(type: "int", nullable: true),
                    LabID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_reservations_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "clinics",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_reservations_labs_LabID",
                        column: x => x.LabID,
                        principalTable: "labs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_reservations_placePrice_PlacePriceId",
                        column: x => x.PlacePriceId,
                        principalTable: "placePrice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NID", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, new DateTime(2002, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "a91e415d-99bd-44ce-8b17-239299c967ca", null, false, "male", false, null, "2636523632", "Mohamed", "MOHAMED@EXAMPLE.COM", "MOHAMEDALI123", null, null, false, "e8096c73-0ba5-499a-b1f5-05b4211b6cf7", false, "MohamedAli123" },
                    { "2", 0, new DateTime(2012, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "88e72826-066b-481f-b7bf-b15986d2e71a", null, false, "Female", false, null, "5312523632", "Mona", "MONA@EXAMPLE.COM", "MONAOMAR123", null, null, false, "d4b3299e-a697-4448-8632-da982348ea49", false, "monaomar123" }
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
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 1, "Description of report 1", "11", new DateTime(2024, 3, 9, 21, 50, 34, 313, DateTimeKind.Local).AddTicks(7207), "1" },
                    { 2, "Description of report 2", "22", new DateTime(2024, 3, 8, 21, 50, 34, 313, DateTimeKind.Local).AddTicks(7268), "2" }
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
                table: "documents",
                columns: new[] { "ID", "Content", "ReportID" },
                values: new object[,]
                {
                    { 1, new byte[0], 1 },
                    { 2, new byte[0], 2 }
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
                table: "placeEquipments",
                columns: new[] { "ID", "EntityID", "EquipmentID", "PlaceType" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "placePrice",
                columns: new[] { "ID", "Name", "PlaceID", "PlaceType", "Price" },
                values: new object[,]
                {
                    { 1, "X-Alpha", 2, 0, 341.39999999999998 },
                    { 3, "X-ray", 1, 0, 260.39999999999998 }
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
                columns: new[] { "ID", "ClinicID", "LabID", "PlacePriceId", "SerialNumber", "State", "Time", "UserID" },
                values: new object[,]
                {
                    { 1, null, null, 1, 0, 0, new DateTime(2024, 3, 11, 21, 50, 34, 313, DateTimeKind.Local).AddTicks(7418), "1" },
                    { 2, null, null, 1, 0, 1, new DateTime(2024, 3, 12, 21, 50, 34, 313, DateTimeKind.Local).AddTicks(7427), "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_clinics_DepartmentID",
                table: "clinics",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_departments_HospitalID",
                table: "departments",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_documents_ReportID",
                table: "documents",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_labs_HospitalID",
                table: "labs",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_medicinesType_MedicineID",
                table: "medicinesType",
                column: "MedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_medicinesType_TypeID",
                table: "medicinesType",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_pharmacies_HospitalID",
                table: "pharmacies",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_pharmacyMedicines_MedicineTypeID",
                table: "pharmacyMedicines",
                column: "MedicineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_pharmacyMedicines_PharmacyID",
                table: "pharmacyMedicines",
                column: "PharmacyID");

            migrationBuilder.CreateIndex(
                name: "IX_placeEquipments_EntityID",
                table: "placeEquipments",
                column: "EntityID");

            migrationBuilder.CreateIndex(
                name: "IX_placeEquipments_EquipmentID",
                table: "placeEquipments",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_placePrice_PlaceID",
                table: "placePrice",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_placeShifts_EntityID",
                table: "placeShifts",
                column: "EntityID");

            migrationBuilder.CreateIndex(
                name: "IX_placeShifts_ShiftID",
                table: "placeShifts",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_reports_UserID",
                table: "reports",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_reportsMedicines_MedicineTypeID",
                table: "reportsMedicines",
                column: "MedicineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_reportsMedicines_ReportID",
                table: "reportsMedicines",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_ClinicID",
                table: "reservations",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_LabID",
                table: "reservations",
                column: "LabID");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_PlacePriceId",
                table: "reservations",
                column: "PlacePriceId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_UserID",
                table: "reservations",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_testLabs_LabID",
                table: "testLabs",
                column: "LabID");

            migrationBuilder.CreateIndex(
                name: "IX_testLabs_TestLabID",
                table: "testLabs",
                column: "TestLabID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "pharmacyMedicines");

            migrationBuilder.DropTable(
                name: "placeEquipments");

            migrationBuilder.DropTable(
                name: "placeShifts");

            migrationBuilder.DropTable(
                name: "reportsMedicines");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "testLabs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "equipments");

            migrationBuilder.DropTable(
                name: "pharmacies");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "medicinesType");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropTable(
                name: "placePrice");

            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "clinics");

            migrationBuilder.DropTable(
                name: "labs");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "hospitals");
        }
    }
}
