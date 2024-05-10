using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_reports_ReportID",
                table: "attachments");

            migrationBuilder.DropIndex(
                name: "IX_attachments_ReportID",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "attachments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c50174b0-6d53-41b1-9315-baa936611361", "d3f2c411-a6f5-430b-9d01-59dd52d7e0fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca891f44-9325-4da9-8c40-fa5c0f339469", "2d16e5b6-3388-4d7e-a23b-5b834c16d54a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0245bb1b-ec82-4f81-b876-b0aa15eec8c4", "97b9596f-0971-4e97-999b-4990c78ee5b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a0af647-84d9-4a54-a1a5-a00e09924c73", "1e5dafa8-f86f-4976-a5ce-1072ff3eaea6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "190e8b4c-e9cb-4398-bbd5-2800e43fe096", "387d4cb8-912e-4819-8f96-de097686868c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fec155f5-f909-44c6-8750-a9329345fa7a", "c2748a74-a0dd-4bde-b80f-8439f49c2975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7b078c2-b764-497e-854e-26ec302c05d8", "41fd2336-5288-4d48-8c0a-5c7727edc336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63fa3e9f-3525-4ac5-ac5a-6d5ffbc0fe82", "1d1c4ebf-f5c3-4f4d-8f79-d2236d09017e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6b20da0-d857-404a-b37b-651638e4a8bf", "1897bd99-e519-46a7-a537-4003d1afe535" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "862fbb5a-c858-4ab9-8e0a-f1ebea956685", "5a6a02c0-457a-4719-8d89-da4f6a8f812c" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 5, 9, 21, 53, 20, 774, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 5, 8, 21, 53, 20, 774, DateTimeKind.Local).AddTicks(4982));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "attachments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb5ae019-be13-4d89-962f-fcf76bfe190d", "3730c1f0-aa1f-40ff-9076-22569375c8d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d41a8f0-6b14-48f1-aaf7-2949dd842411", "c0a03bc5-e0b8-4db6-a758-c501196bd986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "258b860c-b497-453d-8c31-79d925116fe2", "7bd14192-916d-4f67-81d4-4f02da6f28e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac328fc0-df9e-4237-984e-a55fdef6544c", "62185664-dcde-4db0-b704-8bdc22544591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce45d7c3-2d38-4a13-a776-e7c72d349ca2", "2a577cd7-3787-4d43-a2ee-536cf4e61493" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a21aa1d-0d0a-4b71-b04d-fd3a1e5f5da0", "37d40f4f-86e7-40a8-8a96-1dcb40d6c2bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21ee709e-cca3-4369-bdab-fa1c1c72f796", "44a83d81-87bb-490b-a741-558f9469a094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "388461a1-4fcf-47f0-9667-6781b4b02654", "a1e2241c-7818-42da-badd-8b81847bb515" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed3399e4-9d57-4832-b43c-30f58525e687", "16929571-5bde-4bc9-906f-1f1fd81c2991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e4cefb6-2b22-4240-ad3c-ee4c47cb0e58", "fb3709a8-c8b9-4b44-938e-3767b9464907" });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                column: "ReportID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                column: "ReportID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                column: "ReportID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 4, 27, 21, 27, 0, 586, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 4, 26, 21, 27, 0, 586, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.CreateIndex(
                name: "IX_attachments_ReportID",
                table: "attachments",
                column: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_reports_ReportID",
                table: "attachments",
                column: "ReportID",
                principalTable: "reports",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
