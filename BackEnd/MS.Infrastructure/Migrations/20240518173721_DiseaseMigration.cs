using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DiseaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UserDiseases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "UserDiseases",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "UserDiseases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ValueResult",
                table: "UserDiseases",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "UserDiseases",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkDays",
                table: "clinics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDiseaseId",
                table: "attachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "Gender", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "O+", "90ac7c59-764f-4f5c-9905-ee234a0fa5b0", "Mohamed", "Male", "Single", "af1e9da9-416b-41dc-a9a8-d7a2348af0cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "A+", "ef0ca64b-4ce1-421c-bc34-47c13f4ccc8a", "Laila", "Married", "d795957a-1ea0-49ab-9f4d-aa5d1628be51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "LastName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "A+", "c9b13504-46be-4ca4-b0a9-2cacadd678fc", "Mona", "Omar", "Single", "2df55cfa-a01e-491b-91bf-7e5069039440" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "B+", "c69007a5-ac87-4b25-a066-431d36230220", "Mohammed", "Married", "86bcfd27-6f79-47bd-a7d0-19732c738a85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "AB+", "50adf63e-47a9-4d51-8a19-b8ba491d95ab", "Aisha", "Married", "5c30efeb-933f-4c18-b6bf-11430f22f032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "O-", "e794a280-8a0e-46d7-a3c5-0b6477ba8cf8", "Ahmad", "Single", "d66be60e-349b-4d2f-849e-637553d197eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "A-", "4bf6e9e4-65b6-4878-969b-55dd2347d023", "Aya", "Married", "e6331b61-707c-41af-85bd-ae6056dd179c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "B-", "c76b1ef7-69ad-4d92-bab8-febeaf23bc9b", "Omar", "Single", "569329e2-4246-4c70-92d3-6f12ebf60020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "AB-", "1f855e24-9a15-4a2e-994c-47419038accc", "Sara", "Single", "5fb33404-ec4a-4978-878e-071dbc8bd2b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "BloodType", "ConcurrencyStamp", "FirstName", "MaritalStatus", "SecurityStamp" },
                values: new object[] { "O+", "7e1ae19b-9932-454d-8c76-021365376e2e", "Ali", "Single", "de60d4cb-798b-47f0-a6b0-8b93c250c46e" });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "ID", "Causes", "Description", "Name", "Symptoms" },
                values: new object[,]
                {
                    { 1, "Genetic factors, poor diet, lack of exercise, obesity.", "A chronic condition that affects how your body turns food into energy.", "Diabetes", "Increased thirst, frequent urination, extreme hunger, unexplained weight loss, presence of ketones in the urine." },
                    { 2, "Genetic factors, high salt intake, obesity, lack of physical activity, alcohol consumption.", "A condition in which the force of the blood against the artery walls is too high.", "Hypertension", "Often has no symptoms but can include headaches, shortness of breath, or nosebleeds." },
                    { 3, "Genetic factors, respiratory infections, allergens, air pollutants.", "A condition in which your airways narrow and swell and produce extra mucus.", "Asthma", "Shortness of breath, chest tightness or pain, wheezing, coughing." },
                    { 4, "Genetic factors, lifestyle factors such as smoking and diet, environmental exposures to chemicals and radiation.", "A group of diseases involving abnormal cell growth with the potential to invade or spread to other parts of the body.", "Cancer", "Varies by type but can include lumps, abnormal bleeding, prolonged cough, unexplained weight loss." },
                    { 5, "Genetic factors, age, family history, certain genetic mutations.", "A progressive disorder that causes brain cells to waste away (degenerate) and die.", "Alzheimer's Disease", "Memory loss, confusion, difficulty with language, difficulty in making decisions, personality changes." }
                });

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 1,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 3,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 4,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 5,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 6,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 7,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 8,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 9,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "attachments",
                keyColumn: "ID",
                keyValue: 10,
                column: "UserDiseaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 1,
                column: "WorkDays",
                value: "[2,3,5,7]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 2,
                column: "WorkDays",
                value: "[3,4,6]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 3,
                column: "WorkDays",
                value: "[4,5,6,1]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 4,
                column: "WorkDays",
                value: "[2,3,7]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 5,
                column: "WorkDays",
                value: "[3,4,5,6]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 6,
                column: "WorkDays",
                value: "[4,5,7]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 7,
                column: "WorkDays",
                value: "[2,4,6]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 8,
                column: "WorkDays",
                value: "[3,5,7]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 9,
                column: "WorkDays",
                value: "[4,6,1]");

            migrationBuilder.UpdateData(
                table: "clinics",
                keyColumn: "ID",
                keyValue: 10,
                column: "WorkDays",
                value: "[2,3,5,7]");

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

            migrationBuilder.InsertData(
                table: "UserDiseases",
                columns: new[] { "ID", "ApplicationUserId", "Description", "Diagnosis", "DiagnosisDate", "DiseaseId", "Height", "Type", "ValueResult", "Weight" },
                values: new object[,]
                {
                    { 1, "1", "Managed with insulin injections.", "Confirmed Type 1 Diabetes", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1.75, "Type 1 Diabetes", 7.2000000000000002, 70.0 },
                    { 2, "2", "High blood pressure managed with medication.", "Stage 2 Hypertension", new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1.8, "Hypertension", 140.0, 85.0 },
                    { 3, "3", "Chronic condition managed with inhalers.", "Mild Persistent Asthma", new DateTime(2018, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1.6499999999999999, "Asthma", 1.0, 60.0 },
                    { 4, "4", "Undergoing chemotherapy.", "Stage 2 Breast Cancer", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1.7, "Cancer", 3.3999999999999999, 65.0 },
                    { 5, "5", "Progressive memory loss.", "Early Onset Alzheimer's", new DateTime(2017, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1.6000000000000001, "Alzheimer's Disease", 4.5, 55.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_attachments_UserDiseaseId",
                table: "attachments",
                column: "UserDiseaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_attachments_UserDiseases_UserDiseaseId",
                table: "attachments",
                column: "UserDiseaseId",
                principalTable: "UserDiseases",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attachments_UserDiseases_UserDiseaseId",
                table: "attachments");

            migrationBuilder.DropIndex(
                name: "IX_attachments_UserDiseaseId",
                table: "attachments");

            migrationBuilder.DeleteData(
                table: "UserDiseases",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserDiseases",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserDiseases",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserDiseases",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserDiseases",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UserDiseases");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "UserDiseases");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "UserDiseases");

            migrationBuilder.DropColumn(
                name: "ValueResult",
                table: "UserDiseases");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "UserDiseases");

            migrationBuilder.DropColumn(
                name: "WorkDays",
                table: "clinics");

            migrationBuilder.DropColumn(
                name: "UserDiseaseId",
                table: "attachments");

            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "Gender", "SecurityStamp" },
                values: new object[] { "2638b80d-1d8b-47d2-915b-062f93b39f7d", "mohamed", "male", "68889af8-6b8f-476a-bce4-d67c39023030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "8bed64ef-a32b-46a3-903e-a96a59017c4d", "mohamed", "b491b644-2706-49b1-8735-891868508d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp" },
                values: new object[] { "b0426683-f97b-4bb5-ba08-717627dcab3e", "mohamed", "Ali", "2af902c5-5469-4cd4-8486-c06331844e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "a3ddb0ae-5f7f-49a9-97a0-375a85642411", "mohamed", "439a3102-3734-4e06-b8fb-53e2891e036c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "723261d7-cc8b-4c26-850f-fed97226aaeb", "mohamed", "1c9070d6-a8e7-40b7-84db-e45b671157b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "cb31f8f2-242b-413a-aee3-a35d7ad617e3", "mohamed", "34bcb9df-088d-43ea-a796-42b503df22d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "ef794e42-10f9-4c3e-83af-1415251af4bc", "mohamed", "6ddfdec4-4bf2-4394-b5b3-6d581b1d822b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "4a18a558-1f2b-4970-807f-2cb4a12e50e8", "mohamed", "8e15ad88-6b33-4d93-9fbb-b85c0c1ecd2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "2aaff115-568a-462f-92b8-2d96afccd610", "mohamed", "b7999da5-6b31-4a3e-9753-da754b4cdc64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "FirstName", "SecurityStamp" },
                values: new object[] { "de9f1788-5381-4c8e-8242-e186ee6e8e03", "mohamed", "7592568f-7f37-499c-8a71-e033f7df4a76" });

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 5, 10, 0, 53, 42, 3, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "reports",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 5, 9, 0, 53, 42, 3, DateTimeKind.Local).AddTicks(363));
        }
    }
}
