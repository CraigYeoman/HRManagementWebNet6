using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementWeb.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "27839d84-b298-4fd2-b764-92d2632c94cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "1a503b11-6b70-437a-8b6f-ea58a145a28b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd7226d-268d-411a-b7c2-e235d1457b1a", "AQAAAAEAACcQAAAAEE5Y4PxtQN2L+Dlxz0cz9Q7yO7GW3UazNiD4ucD/aa1aseMDBap2RbiutDNe7SNhXA==", "e1c36b27-b1b2-4a9c-b982-a0b573dd9444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cc987f5-4ff3-494a-80bb-f9e881ae4fe4", "AQAAAAEAACcQAAAAEBrTZsbOFqFdFLtsbBFF1ppijnEvhwj/eioNxazovfRSp45yNw6nK5Ds8qnEeJ+pBg==", "f0e31d52-9e0d-458b-857a-5c59476413b9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f6ad1316-8179-49b4-bfc4-6f8c55434af2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "285696a3-667b-4655-871a-16d9543a8b10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a17f5dd1-1bfa-4f07-aaf4-c8387459af3a", "AQAAAAEAACcQAAAAEIThd3v6fLxWYcy5HOYbPV7lEHFMWzyRYaW+eoNpXxEhFJJhKJQMUMMwAwl88Z4uLg==", "04c1ca53-666d-4971-9e24-364bb9cdf7db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe0f74d3-44b0-4d70-a6e4-9204cb6e66d3", "AQAAAAEAACcQAAAAEJ8cTsqLYPvy6teA0bWVRrhl+xUAdiS/WSNnSuqhHtdFZyhxN52OCwrvEMXXFfRYkw==", "c9113127-03d3-4d1c-96cb-be18713d0897" });
        }
    }
}
