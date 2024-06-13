using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class userAvatar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "attachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "b1700e45-9a6c-4be5-9873-17e633b08cb0", "5d78fd03-2de5-45b7-813d-fdb06169c6ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "dd0ebb3b-7e4e-4bc9-b303-b8d1cf04c4ac", "b548e794-66b2-46ca-8a1c-73c4b0d35da1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "3f938692-1b01-488a-8e73-bf9867d20345", "7118e0f1-5758-4309-8a42-75fe575ddf19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "1f0063b5-a2b9-4519-8542-2fcea1cc4145", "e852e452-f3f8-4e48-a0aa-b6690ec1667d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "d276fef7-3b35-47a4-bd9e-db029d504d66", "0388058f-3df5-4925-9ad5-f9592771e2f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "c28cef22-17e7-4cdd-ba35-ad787b29d280", "9c00f79b-7904-4aa5-b921-5414c118332d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "9673543c-199b-4c85-8225-1165e264d8bf", "f41a8252-501c-4723-a770-54e69d2808d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "42249dbf-bec4-4352-a6b2-450e9d7cb346", "d52597de-a3da-49ac-9b62-99e2604afd58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "8de6b129-b465-4394-a02d-0db819b6737f", "a6190eaa-191b-466b-94d6-6f0b8a57dc26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "AvatarId", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { null, "24cc3a33-bf31-484c-bd7c-71fceea3c3bf", "1014bd28-6188-497e-9621-9b6b3425f480" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_attachments_AvatarId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AvatarId",
                table: "AspNetUsers");

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
                values: new object[] { "5d4a8e69-21f5-4373-8166-32b576112076", "4535ff23-ab81-4b83-9a5f-8538dfbefd78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c51744ea-d4f6-4465-955d-a27a947cb86b", "6cdb62b0-7177-4d5c-a2ab-7dd2bcff94ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b409b74-6ece-4c2c-a8b7-9520996e40c6", "fe44130c-ad57-44c3-bbcb-95d41daef5d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96b0cce8-3ae6-465c-8656-88545ec97a92", "2111eab7-4d86-43df-b1a8-35edd5315033" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7b29329-3529-4d8b-bbf7-db70c9d96cf2", "697f05cb-4821-48f4-b97d-12372bd4ff74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eda5be43-05d1-4673-bce3-2c2e06eaee47", "bd05804a-7606-4a56-9465-973d4268cda7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "036ec756-657f-46c0-863c-fca5e14e096b", "514f17a6-9765-42f3-a6dd-ef73ac284524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "399ece79-735b-438d-9979-93cd575de9bc", "827b611d-2654-4120-afe4-59e7f639e7a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a9736d6-e1f5-4af6-909c-180b1da25f22", "2c186aff-1c2f-43a7-a0c5-9d90d8114228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d733d9bb-dc8c-4d30-825c-ca3473da6923", "9f3e8e47-5435-439b-8823-b4cc9a4b176b" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 6, 8, 14, 37, 36, 765, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 6, 7, 14, 37, 36, 765, DateTimeKind.Local).AddTicks(7639));
        }
    }
}
