using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c929802-75fc-4e2f-be33-d0115c770504", "f6bedbd1-b718-40be-b133-cf23a14026a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82e3d0d1-e07b-4b0f-852d-8eb33ba19642", "584c2f49-e1d8-4afc-a28e-cec564c13afb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "609fd2ed-dc8a-4bd4-bb20-9bcf1c8b7153", "60e5648d-3fb9-4e21-8b5e-f5615c78f340" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a824c28-2ab1-4615-bbc8-c86d2f56d4e1", "ceb09e65-22ed-4cfe-aaff-de0b6122252b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c1ca68e-f2a4-4e23-831c-3128e66b02d0", "0e4fdc15-6b02-4e71-ba9c-391b33544c13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "717a3219-9851-4fe9-83ba-87bea9df3158", "909489a3-85ba-4fae-9d04-56312b6e5874" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be8ff9b8-cd65-4528-a03a-7ec2d0c66c34", "bcfbaca2-6114-4ad0-8b43-d61a648d49c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74233553-6c77-40c9-a619-86e9c70289e5", "5d82d6bd-d3fa-4e24-b807-28b3dee57ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1edeb11-93ab-4a64-94d0-bbe5870f3970", "2e968e1e-517a-4f83-95b8-1bb30ed589e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdfe92cd-5e2d-46eb-989f-dc85d600b309", "db8c3f96-d9a7-4d77-b714-7251bdb5b513" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 4, 26, 0, 45, 11, 730, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 4, 25, 0, 45, 11, 730, DateTimeKind.Local).AddTicks(5923));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d95b256-336c-431a-9556-ca23f67d4eaf", "42c43e7b-3990-4558-9a42-f30b914cd9e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67d47790-52fe-4835-8c01-304ef4ac2d7c", "1da1a83f-987d-4508-a383-4fe9b79f1a7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4889d7a-a977-4d29-b0cb-1f05985de7f5", "f7342374-bd4f-407c-8b01-9d90bd0cffaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "531d569d-db0d-455c-b669-f3149d4fe874", "d06598ac-40e4-4567-8c7b-4bb7e4fe33b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d188dbb9-20b2-4458-8a7c-cbc559036e50", "b817b204-2d4e-4868-9730-b22a7bd1c5a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "333ddfd2-ac49-4f4d-8025-8236c0392197", "d4543a47-f22d-41e6-a94a-8563b46e5df2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ddeadcb-c0bf-4006-a65c-1731817d27df", "1a7192c3-a4a6-48e3-bd2e-efc8084b0a17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a210a3d0-841d-43a2-b58b-91bc4843b115", "aa527cbf-12a6-4487-a7bb-11fad948998e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6056c57f-5842-445d-8e90-9461905d3ac2", "44d73e1d-ff0c-47f4-b04c-bdfbfd31f7fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce31b51c-73c4-412c-ac63-3e4df9290ab8", "40b68d9b-83c3-4e0e-afa5-04ccc82140b5" });

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
    }
}
