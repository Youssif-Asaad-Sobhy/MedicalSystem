using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DiseaseMigrationV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TestId",
                table: "attachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "attachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea012e79-7d49-47b7-baa5-31fe3854909a", "a5960160-b618-40e5-8ba0-169328c6e7ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0d5a468-716a-4c56-a440-8028b69e64de", "706d35ff-f88b-4523-91bd-0e3b19bdd195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "364e752c-07a0-4bdb-8971-765120079036", "f43e6448-3f56-4c51-95b2-c60ccd0e753a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2373de1-fb7c-4c35-bc94-1d51fc28d679", "acd06b08-7970-4324-905b-91193a1b8b39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25209ef3-05b6-4154-88ff-23fe759d312a", "42455be6-77f1-4d33-84f7-4df49d737e3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f15bcf2-d674-4033-9b3e-ca4101bcc47a", "55c026cf-2fb6-465e-9ddf-7f25c3914a91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37503d24-8470-4d73-8cb7-84607734878b", "12e31230-83d2-4536-83d4-f7c692966cec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b23a229-0748-456a-ada3-82fcc76b8e68", "fd17358b-30b0-47c1-b79d-38a0c063130d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06c2ff0d-a677-43b4-ae7c-2e400f33a011", "05dff626-925b-4a41-b48e-ad2076af6e8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d2c2784-b70f-4d31-8c58-5c8888e8c115", "096bc853-7fdb-4bbf-b981-0ce2c5165dce" });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 5, 17, 20, 40, 37, 537, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 5, 16, 20, 40, 37, 537, DateTimeKind.Local).AddTicks(6584));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TestId",
                table: "attachments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClinicId",
                table: "attachments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90ac7c59-764f-4f5c-9905-ee234a0fa5b0", "af1e9da9-416b-41dc-a9a8-d7a2348af0cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef0ca64b-4ce1-421c-bc34-47c13f4ccc8a", "d795957a-1ea0-49ab-9f4d-aa5d1628be51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9b13504-46be-4ca4-b0a9-2cacadd678fc", "2df55cfa-a01e-491b-91bf-7e5069039440" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c69007a5-ac87-4b25-a066-431d36230220", "86bcfd27-6f79-47bd-a7d0-19732c738a85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50adf63e-47a9-4d51-8a19-b8ba491d95ab", "5c30efeb-933f-4c18-b6bf-11430f22f032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e794a280-8a0e-46d7-a3c5-0b6477ba8cf8", "d66be60e-349b-4d2f-849e-637553d197eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bf6e9e4-65b6-4878-969b-55dd2347d023", "e6331b61-707c-41af-85bd-ae6056dd179c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c76b1ef7-69ad-4d92-bab8-febeaf23bc9b", "569329e2-4246-4c70-92d3-6f12ebf60020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f855e24-9a15-4a2e-994c-47419038accc", "5fb33404-ec4a-4978-878e-071dbc8bd2b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e1ae19b-9932-454d-8c76-021365376e2e", "de60d4cb-798b-47f0-a6b0-8b93c250c46e" });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "ClinicId", "TestId" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 5, 17, 20, 37, 19, 163, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 5, 16, 20, 37, 19, 163, DateTimeKind.Local).AddTicks(7720));
        }
    }
}
