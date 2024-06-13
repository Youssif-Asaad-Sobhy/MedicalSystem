using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userAvatarId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_attachments_AvatarId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AvatarId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "attachments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f573800-e29a-4d49-a590-0fbcab59556f", "88c0f1b0-b92e-4ad1-93a1-0d5d51c2b9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f370fa29-4f98-4340-a9a0-f7912fcf7a33", "11dd8d33-2c5c-4ae4-86e2-6e312de4376e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb6782a1-5c94-4344-b9c6-d7f2120d834a", "3ca34e4f-0e81-48cb-bd18-b452fe4c7af6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ebb6b34-da76-48e8-9077-eedc0bf393b9", "e3515153-a174-4ba0-ade3-12af68ff57b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6edaddbf-5a1e-4a70-b784-8bc47df0bbe1", "7c0e6431-0377-430e-b40e-56b559e9f382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24bb8e1e-6bf3-435f-a5d8-bcf9d619ca72", "a430fefe-21c7-405c-a70b-ff3c32b5b956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84928090-9e71-423e-82bd-c672e99fdc07", "7e940392-33d3-4488-9206-375d0f07da6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d7bf193-055c-46db-8cfc-ef0621234d4e", "f69e1c91-7572-4868-b382-bcc0a0e91333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c99ebedd-a010-4d88-a099-9d2f38d71e3e", "edd71feb-859b-4196-bbf4-1e47143b0384" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9a0da98-3903-4341-89cf-2c38a7f67500", "78f4993b-f018-4f28-bc2c-b13a5e0f0e54" });

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

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 6, 10, 16, 52, 38, 977, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 6, 9, 16, 52, 38, 977, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.CreateIndex(
                name: "IX_attachments_ApplicationUserId",
                table: "attachments",
                column: "ApplicationUserId",
                unique: true,
                filter: "[ApplicationUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_AspNetUsers_ApplicationUserId",
                table: "attachments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_AspNetUsers_ApplicationUserId",
                table: "attachments");

            migrationBuilder.DropIndex(
                name: "IX_attachments_ApplicationUserId",
                table: "attachments");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "attachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1700e45-9a6c-4be5-9873-17e633b08cb0", "5d78fd03-2de5-45b7-813d-fdb06169c6ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd0ebb3b-7e4e-4bc9-b303-b8d1cf04c4ac", "b548e794-66b2-46ca-8a1c-73c4b0d35da1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f938692-1b01-488a-8e73-bf9867d20345", "7118e0f1-5758-4309-8a42-75fe575ddf19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f0063b5-a2b9-4519-8542-2fcea1cc4145", "e852e452-f3f8-4e48-a0aa-b6690ec1667d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d276fef7-3b35-47a4-bd9e-db029d504d66", "0388058f-3df5-4925-9ad5-f9592771e2f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c28cef22-17e7-4cdd-ba35-ad787b29d280", "9c00f79b-7904-4aa5-b921-5414c118332d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9673543c-199b-4c85-8225-1165e264d8bf", "f41a8252-501c-4723-a770-54e69d2808d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42249dbf-bec4-4352-a6b2-450e9d7cb346", "d52597de-a3da-49ac-9b62-99e2604afd58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8de6b129-b465-4394-a02d-0db819b6737f", "a6190eaa-191b-466b-94d6-6f0b8a57dc26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24cc3a33-bf31-484c-bd7c-71fceea3c3bf", "1014bd28-6188-497e-9621-9b6b3425f480" });

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

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 6, 10, 16, 25, 54, 660, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 6, 9, 16, 25, 54, 660, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AvatarId",
                table: "AspNetUsers",
                column: "AvatarId",
                unique: true,
                filter: "[AvatarId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_attachments_AvatarId",
                table: "AspNetUsers",
                column: "AvatarId",
                principalTable: "attachments",
                principalColumn: "ID");
        }
    }
}
