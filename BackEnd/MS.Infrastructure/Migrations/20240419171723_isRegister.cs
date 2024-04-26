using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class isRegister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "shifts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "shifts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "medicinesType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsRegister",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "7d95b256-336c-431a-9556-ca23f67d4eaf", true, "42c43e7b-3990-4558-9a42-f30b914cd9e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "67d47790-52fe-4835-8c01-304ef4ac2d7c", true, "1da1a83f-987d-4508-a383-4fe9b79f1a7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "c4889d7a-a977-4d29-b0cb-1f05985de7f5", true, "f7342374-bd4f-407c-8b01-9d90bd0cffaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "531d569d-db0d-455c-b669-f3149d4fe874", true, "d06598ac-40e4-4567-8c7b-4bb7e4fe33b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "d188dbb9-20b2-4458-8a7c-cbc559036e50", true, "b817b204-2d4e-4868-9730-b22a7bd1c5a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "333ddfd2-ac49-4f4d-8025-8236c0392197", true, "d4543a47-f22d-41e6-a94a-8563b46e5df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "7ddeadcb-c0bf-4006-a65c-1731817d27df", true, "1a7192c3-a4a6-48e3-bd2e-efc8084b0a17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "a210a3d0-841d-43a2-b58b-91bc4843b115", true, "aa527cbf-12a6-4487-a7bb-11fad948998e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "6056c57f-5842-445d-8e90-9461905d3ac2", true, "44d73e1d-ff0c-47f4-b04c-bdfbfd31f7fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "IsRegister", "SecurityStamp" },
                values: new object[] { "ce31b51c-73c4-412c-ac63-3e4df9290ab8", true, "40b68d9b-83c3-4e0e-afa5-04ccc82140b5" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 4, 18, 19, 17, 20, 909, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 4, 17, 19, 17, 20, 909, DateTimeKind.Local).AddTicks(9219));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRegister",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "shifts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "shifts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "medicinesType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81d60ef3-9751-48cc-98c3-f9fa643c723b", "02ff957c-7e36-4a19-b193-66cb235559be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d2eacfe-0dd8-4aff-bc26-a1ce17b61e28", "450a608e-bd99-480f-a2fa-778e351fb459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8943034c-fe99-44f8-b4cb-2c7973069e46", "99825a65-c201-4930-b8bc-c4387dce02e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bce51ee7-6736-4ef4-8486-3719017f6d1a", "66361e22-a0ef-4f43-829b-bbf187dbfad9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43b18fc1-5143-427e-80f7-a054fb8e3a4e", "45a5484e-a7d1-44b9-9f96-d4a2da3f02e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d697590-f6bf-4d5c-8cd8-6905237412a2", "26257be4-983e-49c0-b24a-b86a25cb7ef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70a43227-a890-4c9a-a815-61b31f7efd20", "45850d9e-f784-4821-a229-d902d46d3c89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b84c99ee-c6b9-44b6-a1a9-598551ddebaa", "b75f1779-8f0d-449a-93d5-e7a2b2b367ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a898a0e9-91a1-44bd-9c96-e3595d0e5a90", "1adf9e11-6a1d-43a2-aa81-98733cd08ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c35bb36c-a66a-485b-bfec-6ef1226d91d4", "62c44bcf-9989-4b5d-85d9-5476d6a5d02d" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 21, 14, 7, 46, 112, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 20, 14, 7, 46, 112, DateTimeKind.Local).AddTicks(1444));
        }
    }
}
