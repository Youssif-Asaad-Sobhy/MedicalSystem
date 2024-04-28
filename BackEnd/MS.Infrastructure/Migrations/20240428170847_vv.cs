using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class vv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d619ccc2-55a6-4950-9e51-7cd9d8f76e15", "eadcb6b2-88da-4a34-b0c6-162186433ba6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "656b4c9b-d527-42ae-9cf3-63b0dc389cb5", "9fe85f70-2e85-49c0-bf82-dba416878692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0c4f52b-2c24-4549-a4a2-687fc3ccffb0", "981239b4-b3c2-4dca-b3e2-25cbbc6f050a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "273535f3-70d9-4366-859f-5e048ee09333", "5a106b06-78d2-4b43-9ed5-4964c0564fe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d716077-3d41-4333-9f06-1916f2cc9b62", "fe79ef7c-6086-4bca-ab0b-435c20035639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e299901-d3fa-4640-af5a-6d128651f24e", "696a9786-04fb-4832-ba8f-ce99ad727ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c386f467-247b-459d-881b-75950f3586a3", "d47750d8-c648-4f39-af8b-585a78f6f426" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b744063f-7c8f-45ec-b7c9-cca6d3fc4245", "965e0f33-78af-43aa-848c-b156332a7572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17c2f18d-aede-4b27-a09e-0633be238c98", "14dec92f-e520-48bc-b3f3-d029583582f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ada6e82d-c825-4b32-af62-0d06ac31f918", "f1489df1-546f-4dbf-b760-d127b6eabd64" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 4, 27, 20, 8, 44, 947, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 4, 26, 20, 8, 44, 947, DateTimeKind.Local).AddTicks(5975));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07495093-4b91-4012-a8de-b84c24da0176", "6ff6fcde-ca1e-492c-b125-5c36958df3f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29170b5c-4d6d-49e2-bbd5-d24f60259e2d", "f1c27a17-aaa4-412e-90fe-4a2166ce9d60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31a026bb-bf2a-49ee-8fa2-78af1d412dae", "0fec1c6a-c58f-49fd-9e69-e6686993b66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc186d41-09b4-4583-b703-b5cada14fd38", "83872fc0-5307-443a-ad0f-fdbbfcc654f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fa540a8-9337-458c-bf75-755391500ab5", "735ad2f4-c040-45cb-93fe-f93238450b61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5ec921c-a541-406b-91c0-2b07e9758524", "3bd4781d-96a0-4b16-b87a-7ccd1343e7f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "818a01cd-1b76-4327-b241-14d2f2d5f60e", "6258bdc1-d787-4dcb-b117-884934826339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7030874e-6804-4d55-a69f-cd48059f91b2", "4197d9a8-c66c-49e5-9444-f48edd782be6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48fd5b9f-685a-4782-b00f-0559266648ed", "d72f500c-e91d-445e-bd6d-a80386911b91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5186327e-979d-4b4d-af65-21655c599dfe", "8bae8177-5c97-4bc9-aae7-48d1a475d310" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 4, 27, 20, 7, 19, 657, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 4, 26, 20, 7, 19, 657, DateTimeKind.Local).AddTicks(8676));
        }
    }
}
