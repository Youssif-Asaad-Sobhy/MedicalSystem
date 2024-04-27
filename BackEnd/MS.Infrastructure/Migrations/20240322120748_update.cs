using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92fe2fcf-e5f9-41d8-ada0-f803319e280e", "54aef1fe-1feb-4fb5-9140-220211097cea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c03f6c2b-9e73-469f-87f2-0c046970dd21", "c10f5538-0a58-4c13-a5ad-24dc1ec700e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fee9f00-e3c4-4e03-8256-4f0964ebf152", "737e95f5-f5ba-4e71-a211-d6d4e2710684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe972342-5359-4eaa-872d-91b70d78c6c5", "cd7bcfcb-37ec-46c9-b26f-fa34de79b831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d861933-5272-43fe-8523-124ffc6ded75", "f39aef64-9c2e-4540-ac4f-c614dbf1a360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfb696dd-c773-4ffe-ab1a-c3958efb40fb", "9d0ad30a-a1f5-402d-9319-aaf0f21d834a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1e62847-4ab6-4450-bb18-dc2655e8d3c8", "6ca9a4cf-93f5-42ce-b722-c95480d17ecb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9d5d61a-5384-4f57-9fc4-2dcbd786998a", "766420ed-8f8b-4462-b72e-d514971c578c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4a7eafe-b032-4ad8-a3f4-cddaed3a673f", "de071a92-eff2-4c55-819f-d4ba29a88249" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69e3381c-d9e3-4f82-9b5c-89eb77ac9bd7", "037ee81c-e387-49f5-9bbc-33b95d21a602" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 13, 15, 48, 51, 482, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 12, 15, 48, 51, 482, DateTimeKind.Local).AddTicks(2584));
        }
    }
}
