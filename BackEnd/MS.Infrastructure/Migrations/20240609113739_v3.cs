using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "tests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestResultID",
                table: "attachments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TestResults_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestResults_tests_TestId",
                        column: x => x.TestId,
                        principalTable: "tests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 4,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 5,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 6,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 7,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 8,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 9,
                column: "TestResultID",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 10,
                column: "TestResultID",
                value: null);

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

            migrationBuilder.UpdateData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "tests",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_attachments_TestResultID",
                table: "attachments",
                column: "TestResultID");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_ApplicationUserId",
                table: "TestResults",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_TestResults_TestResultID",
                table: "attachments",
                column: "TestResultID",
                principalTable: "TestResults",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_TestResults_TestResultID",
                table: "attachments");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_attachments_TestResultID",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "TestResultID",
                table: "attachments");

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
    }
}
