using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removedReportAndReporMedicineTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_AspNetUsers_ApplicationUserId",
                table: "attachments");

            migrationBuilder.DropTable(
                name: "reportsMedicines");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropIndex(
                name: "IX_attachments_ApplicationUserId",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16f42d2d-f9bb-4f05-ad26-6086f8d77abc", "d0461953-32ff-4f88-9753-f88315464c21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ad2fa1c-4a9b-4791-b8a7-b4f95925e345", "c08ee7a3-0025-4e0e-87cb-1a2828a1c89f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "edeab9e5-4752-4181-8589-7cab91451c87", "74ae7286-8b05-4e78-9eb4-e767d9482a25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efef7251-95b1-4fe3-bc97-79b1a5ad20f3", "6247c2c3-45c6-4159-96f6-21f88ec66d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f6ed540-7582-4c8a-95fe-5325d9bb3910", "7d905a6e-a62c-42ab-b859-188d99ac4cf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7782d6a6-43e2-433f-a457-55b0d349c8ae", "b8bc981a-64d7-4ee2-be23-3144f1bdad82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "946c7069-8b71-4a45-9d2a-eb1785da5f71", "e0de56b2-399c-47bf-bbd0-c9dae652862d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "440d5205-2052-43a8-871a-324bb35cb435", "4d3cec7c-2161-4759-9f2f-b209068ab0d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88cd4503-040a-4f64-bc47-af64edd3096e", "42ed68c3-98e7-4318-ac6c-93782a48170c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7e25e3a-489e-4fb3-922c-211615464bb5", "b1b94038-f558-4f2f-b71a-dd1d80fef0c4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "attachments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "reportsMedicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineTypeID = table.Column<int>(type: "int", nullable: false),
                    ReportID = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "0f573800-e29a-4d49-a590-0fbcab59556f", "88c0f1b0-b92e-4ad1-93a1-0d5d51c2b9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "f370fa29-4f98-4340-a9a0-f7912fcf7a33", "11dd8d33-2c5c-4ae4-86e2-6e312de4376e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "cb6782a1-5c94-4344-b9c6-d7f2120d834a", "3ca34e4f-0e81-48cb-bd18-b452fe4c7af6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "4ebb6b34-da76-48e8-9077-eedc0bf393b9", "e3515153-a174-4ba0-ade3-12af68ff57b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "6edaddbf-5a1e-4a70-b784-8bc47df0bbe1", "7c0e6431-0377-430e-b40e-56b559e9f382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "24bb8e1e-6bf3-435f-a5d8-bcf9d619ca72", "a430fefe-21c7-405c-a70b-ff3c32b5b956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "84928090-9e71-423e-82bd-c672e99fdc07", "7e940392-33d3-4488-9206-375d0f07da6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "1d7bf193-055c-46db-8cfc-ef0621234d4e", "f69e1c91-7572-4868-b382-bcc0a0e91333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "c99ebedd-a010-4d88-a099-9d2f38d71e3e", "edd71feb-859b-4196-bbf4-1e47143b0384" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "a9a0da98-3903-4341-89cf-2c38a7f67500", "78f4993b-f018-4f28-bc2c-b13a5e0f0e54" });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 4,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 5,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 6,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 7,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 8,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 9,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 10,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.InsertData(
                table: "reports",
                columns: new[] { "ID", "Description", "DoctorID", "Time", "UserID" },
                values: new object[,]
                {
                    { 1, "Description of report 1", "11", new DateTime(2024, 6, 10, 16, 52, 38, 977, DateTimeKind.Local).AddTicks(1525), "1" },
                    { 2, "Description of report 2", "22", new DateTime(2024, 6, 9, 16, 52, 38, 977, DateTimeKind.Local).AddTicks(1600), "2" },
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

            migrationBuilder.CreateIndex(
                name: "IX_attachments_ApplicationUserId",
                table: "attachments",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_AspNetUsers_ApplicationUserId",
                table: "attachments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
