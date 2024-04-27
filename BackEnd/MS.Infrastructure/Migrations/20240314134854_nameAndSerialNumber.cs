using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nameAndSerialNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "92fe2fcf-e5f9-41d8-ada0-f803319e280e", "mohamed", "Ali", "54aef1fe-1feb-4fb5-9140-220211097cea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "c03f6c2b-9e73-469f-87f2-0c046970dd21", "mohamed", "Ali", "c10f5538-0a58-4c13-a5ad-24dc1ec700e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "6fee9f00-e3c4-4e03-8256-4f0964ebf152", "mohamed", "Ali", "737e95f5-f5ba-4e71-a211-d6d4e2710684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "fe972342-5359-4eaa-872d-91b70d78c6c5", "mohamed", "Ali", "cd7bcfcb-37ec-46c9-b26f-fa34de79b831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "7d861933-5272-43fe-8523-124ffc6ded75", "mohamed", "Ali", "f39aef64-9c2e-4540-ac4f-c614dbf1a360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "cfb696dd-c773-4ffe-ab1a-c3958efb40fb", "mohamed", "Ali", "9d0ad30a-a1f5-402d-9319-aaf0f21d834a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "b1e62847-4ab6-4450-bb18-dc2655e8d3c8", "mohamed", "Ali", "6ca9a4cf-93f5-42ce-b722-c95480d17ecb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "b9d5d61a-5384-4f57-9fc4-2dcbd786998a", "mohamed", "Ali", "766420ed-8f8b-4462-b72e-d514971c578c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "d4a7eafe-b032-4ad8-a3f4-cddaed3a673f", "mohamed", "Ali", "de071a92-eff2-4c55-819f-d4ba29a88249" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "69e3381c-d9e3-4f82-9b5c-89eb77ac9bd7", "mohamed", "Ali", "037ee81c-e387-49f5-9bbc-33b95d21a602" });

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

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "45165153", 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "543864963", 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000001", 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000002", 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000003", 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000004", 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000005", 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000006", 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000007", 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { "70000008", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SerialNumber",
                table: "reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6088455b-73ae-40a6-bea5-81037663b6c0", "8adc4d98-b206-47ff-897e-fe2ba95f0fa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b03c0fc7-de4f-42a9-b2fb-f1021c76f1fa", "022736af-c3ec-496b-bb20-c2a4c3bb9512" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea236a21-468e-4f15-83d7-60550cfdf05a", "a5af322f-050b-4348-9861-2d67b85ce158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78f16d33-a3e9-4c37-ae8f-e46cda5a2808", "64bf9e73-aa0c-46f4-a659-50f764ceef7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54fe6888-83b5-4e8b-9233-58d6f9bb4925", "d14846ab-d8f1-415e-8eb0-85d9bcf220dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57815ff9-fbb5-42b5-8bd4-31f61d11a19c", "560a7718-643e-458a-b616-c16a89f24846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8053c81-9718-4f69-9118-680de9e50ab8", "40ba7847-1851-4760-ad21-7e800e21feb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "beff6eb1-32ea-49f1-80b7-f74274944842", "ec70074f-0da9-4c24-8ecd-6b54a23f216a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0abbe7d-beb7-40e9-bd19-544db021cb54", "c1b8cd6e-7ad6-46ca-a38b-7b4e4afefcf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69a08ddb-17f2-48f6-a410-724256c8d93f", "ba889282-a19a-4c78-9309-0fedd661bfb4" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 12, 13, 25, 44, 588, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 11, 13, 25, 44, 588, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 45165153, 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 543864963, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000001, 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000002, 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000003, 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000004, 0 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000005, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000006, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000007, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "SerialNumber", "State" },
                values: new object[] { 70000008, 0 });
        }
    }
}
