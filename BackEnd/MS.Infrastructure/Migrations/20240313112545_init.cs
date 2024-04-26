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
                name: "OTPs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTPs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OTPs_AspNetUsers_UserID",
                        column: x => x.UserID,
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
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, new DateTime(2002, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6088455b-73ae-40a6-bea5-81037663b6c0", null, false, "male", false, null, "2636523632", "MOHAMED@EXAMPLE.COM", "MOHAMEDALI123", null, null, false, "8adc4d98-b206-47ff-897e-fe2ba95f0fa0", false, "MohamedAli123" },
                    { "10", 0, new DateTime(1982, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "b03c0fc7-de4f-42a9-b2fb-f1021c76f1fa", null, false, "Female", false, null, "1122334455", "LAILA@EXAMPLE.COM", "LAILA4040", null, null, false, "022736af-c3ec-496b-bb20-c2a4c3bb9512", false, "LAILA4040" },
                    { "2", 0, new DateTime(2012, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ea236a21-468e-4f15-83d7-60550cfdf05a", null, false, "Female", false, null, "5312523632", "MONA@EXAMPLE.COM", "MONAOMAR123", null, null, false, "a5af322f-050b-4348-9861-2d67b85ce158", false, "monaomar123" },
                    { "3", 0, new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "78f16d33-a3e9-4c37-ae8f-e46cda5a2808", null, false, "Male", false, null, "9876543210", "MOHAMMED@EXAMPLE.COM", "MOHAMMED123", null, null, false, "64bf9e73-aa0c-46f4-a659-50f764ceef7a", false, "MOHAMMED123" },
                    { "4", 0, new DateTime(1995, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "54fe6888-83b5-4e8b-9233-58d6f9bb4925", null, false, "Female", false, null, "0123456789", "AISHA@EXAMPLE.COM", "AISHA321", null, null, false, "d14846ab-d8f1-415e-8eb0-85d9bcf220dd", false, "AISHA321" },
                    { "5", 0, new DateTime(1978, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "57815ff9-fbb5-42b5-8bd4-31f61d11a19c", null, false, "Male", false, null, "1122334455", "AHMAD@EXAMPLE.COM", "AHMAD567", null, null, false, "560a7718-643e-458a-b616-c16a89f24846", false, "AHMAD567" },
                    { "6", 0, new DateTime(1989, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "e8053c81-9718-4f69-9118-680de9e50ab8", null, false, "Female", false, null, "3344556677", "AYA@EXAMPLE.COM", "AYA789", null, null, false, "40ba7847-1851-4760-ad21-7e800e21feb9", false, "AYA789" },
                    { "7", 0, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "beff6eb1-32ea-49f1-80b7-f74274944842", null, false, "Male", false, null, "5544332211", "OMAR@EXAMPLE.COM", "OMAR101", null, null, false, "ec70074f-0da9-4c24-8ecd-6b54a23f216a", false, "OMAR101" },
                    { "8", 0, new DateTime(1980, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "b0abbe7d-beb7-40e9-bd19-544db021cb54", null, false, "Female", false, null, "7788990011", "SARA@EXAMPLE.COM", "SARA2022", null, null, false, "c1b8cd6e-7ad6-46ca-a38b-7b4e4afefcf2", false, "SARA2022" },
                    { "9", 0, new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "69a08ddb-17f2-48f6-a410-724256c8d93f", null, false, "Male", false, null, "6677889900", "ALI@EXAMPLE.COM", "ALI3030", null, null, false, "ba889282-a19a-4c78-9309-0fedd661bfb4", false, "ALI3030" }
                });

            migrationBuilder.InsertData(
                table: "equipments",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "High-field MRI machine for diagnostic imaging", "MRI Machine" },
                    { 2, "X-ray machine for radiographic imaging", "X-ray Machine" },
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
                    { 1, "New York City", "United States", "State Government", "Mount Sinai Hospital", "+1-212-241-6500", 0 },
                    { 2, "Rochester", "United States", "Local Government", "Mayo Clinic", "+1-507-284-2511", 1 },
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
                    { 1, "Aspirin" },
                    { 2, "Paracetamol" },
                    { 3, "Ibuprofen" },
                    { 4, "Acetaminophen" },
                    { 5, "Omeprazole" },
                    { 6, "Lisinopril" },
                    { 7, "Metformin" },
                    { 8, "Simvastatin" },
                    { 9, "Atorvastatin" },
                    { 10, "Levothyroxine" }
                });

            migrationBuilder.InsertData(
                table: "shifts",
                columns: new[] { "ID", "EndTime", "EntityID", "Name", "PlaceType", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Morning Shift", 0, new DateTime(2024, 2, 17, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 2, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 2, "Evening Shift", 1, new DateTime(2024, 2, 17, 16, 0, 0, 0, DateTimeKind.Unspecified) },
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
                    { 1, "Blood Test" },
                    { 2, "Urinalysis" },
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
                    { 1, "Type 1" },
                    { 2, "Type 2" },
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
                    { 1, 1, "Cardiology" },
                    { 2, 1, "Orthopedics" },
                    { 3, 2, "Neurology" },
                    { 4, 2, "Oncology" },
                    { 5, 3, "Dermatology" },
                    { 6, 3, "Endocrinology" },
                    { 7, 4, "Gastroenterology" },
                    { 8, 4, "Hematology" },
                    { 9, 5, "Immunology" },
                    { 10, 5, "Nephrology" }
                });

            migrationBuilder.InsertData(
                table: "labs",
                columns: new[] { "ID", "HospitalID", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Clinical Pathology Lab", 1 },
                    { 2, 2, "Microbiology Lab", 0 },
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
                    { 1, "Painkiller", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "May cause drowsiness", 1, "Do not exceed recommended dosage" },
                    { 2, "Antibiotic", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Possible nausea and diarrhea", 2, "Take with food" },
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
                    { 1, 1, "Walgreens" },
                    { 2, 2, "CVS Pharmacy" },
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
                    { 1, "Description of report 1", "11", new DateTime(2024, 3, 12, 13, 25, 44, 588, DateTimeKind.Local).AddTicks(8088), "1" },
                    { 2, "Description of report 2", "22", new DateTime(2024, 3, 11, 13, 25, 44, 588, DateTimeKind.Local).AddTicks(8161), "2" },
                    { 3, "Description of report 3", "1", new DateTime(2024, 3, 1, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6357), "1" },
                    { 4, "Description of report 4", "2", new DateTime(2024, 3, 2, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6431), "2" },
                    { 5, "Description of report 5", "3", new DateTime(2024, 3, 3, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6505), "3" },
                    { 6, "Description of report 6", "4", new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6579), "4" },
                    { 7, "Description of report 7", "5", new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6653), "5" },
                    { 8, "Description of report 8", "6", new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6727), "6" },
                    { 9, "Description of report 9", "7", new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6801), "7" },
                    { 10, "Description of report 10", "8", new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6875), "8" }
                });

            migrationBuilder.InsertData(
                table: "clinics",
                columns: new[] { "ID", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Elzahraa" },
                    { 2, 2, "Alpha" },
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
                table: "documents",
                columns: new[] { "ID", "Content", "ReportID" },
                values: new object[,]
                {
                    { 1, new byte[0], 1 },
                    { 2, new byte[0], 2 },
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
                table: "pharmacyMedicines",
                columns: new[] { "ID", "Amount", "MedicineTypeID", "PharmacyID", "Price" },
                values: new object[,]
                {
                    { 1, 50, 1, 1, 10.99 },
                    { 2, 100, 2, 2, 5.9900000000000002 },
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
                table: "reportsMedicines",
                columns: new[] { "ID", "MedicineTypeID", "ReportID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
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
                    { 1, "Description of test lab 1", 1, 100.0, 1 },
                    { 2, "Description of test lab 2", 2, 150.0, 2 },
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
                    { 1, 1, 1, 0 },
                    { 2, 2, 2, 1 },
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
                    { 1, "X-Alpha", 2, 0, 341.39999999999998 },
                    { 2, "X-Beta", 3, 2, 419.99000000000001 },
                    { 3, "X-ray", 1, 1, 260.39999999999998 },
                    { 4, "MRI", 4, 1, 599.99000000000001 },
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
                    { 1, 1, 0, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 3, 1, 2 },
                    { 4, 4, 1, 1 },
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
                    { 1, null, null, 1, 45165153, 0, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(741), "1" },
                    { 2, null, null, 1, 543864963, 1, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(1531), "2" },
                    { 3, null, null, 2, 70000001, 0, new DateTime(2024, 3, 4, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6478), "3" },
                    { 4, null, null, 2, 70000002, 0, new DateTime(2024, 3, 5, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6491), "4" },
                    { 5, null, null, 3, 70000003, 0, new DateTime(2024, 3, 6, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6504), "5" },
                    { 6, null, null, 3, 70000004, 0, new DateTime(2024, 3, 7, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6517), "6" },
                    { 7, null, null, 4, 70000005, 1, new DateTime(2024, 3, 8, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6530), "7" },
                    { 8, null, null, 4, 70000006, 1, new DateTime(2024, 3, 9, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6543), "8" },
                    { 9, null, null, 5, 70000007, 1, new DateTime(2024, 3, 10, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6556), "9" },
                    { 10, null, null, 5, 70000008, 0, new DateTime(2024, 3, 11, 1, 41, 32, 513, DateTimeKind.Local).AddTicks(6569), "10" }
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
                name: "IX_OTPs_UserID",
                table: "OTPs",
                column: "UserID");

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
                name: "OTPs");

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
