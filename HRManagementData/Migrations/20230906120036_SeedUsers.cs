using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementData.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "cbd889bf-0e49-42f4-a6c7-5a5322c61dc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "95fc2031-a9f1-421e-b0d3-5d0ceb93e8a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "Email", "Firstname", "Lastname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e50e52e3-9271-4232-b9e9-294c74382235", "user1@localhost.com", "John", "Connor", "USER1@LOCALHOST.COM", "USER1@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHoZgbM4ZDVnoP5pTOLuG6PXyy+CYL89np1wTP1Pzr88x+8FdjYxvjlLOGFltKLcBA==", "8fd3779a-04d1-4237-859a-4d100fe07930", "user1@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ab0bfc5-c89f-44ab-929c-9a83900ab871", "AQAAAAEAACcQAAAAELrjRHUfWWjaGjM7AToqJIFXq2fK2/M4oAcYcw/h3ExhOpYMkzlV/ESjFKxeAUCjaw==", "b07f96d8-7490-4d34-986c-1f79188ea476" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4410-b416-ba356312e659", 0, "06443e79-3326-4fe8-8eb8-322d25d6cd59", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@localhost.com", true, "Sarah", "Connor", false, null, "USER2@LOCALHOST.COM", "USER2@LOCALHOST.COM", "AQAAAAEAACcQAAAAECVwGiqyaFGXiNUArcTv8Zwzibc+Yysi2O0CvyVajVXxD2ovEGWIXtfFDyyI4WyrBw==", null, false, "75326711-4801-485a-8cb8-6d094ef03103", null, false, "user2@localhost.com" },
                    { "3f4631bd-f907-4411-b416-ba356312e659", 0, "93a02d35-c4c6-4607-8333-b58eaeebb8fc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@localhost.com", true, "Niki", "Lauda", false, null, "USER3@LOCALHOST.COM", "USER3@LOCALHOST.COM", "AQAAAAEAACcQAAAAEE868heAJ5lcPADU93ynPFgd22XfzrDBn0IysEtWZU2oBEgaSRqlrAgX6mCAZvh6fA==", null, false, "f51f2e8a-ea06-423e-bb74-29629884ee59", null, false, "user3@localhost.com" },
                    { "3f4631bd-f907-4412-b416-ba356312e659", 0, "03335653-3438-4d63-8549-811fce02de66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@localhost.com", true, "James", "Hunt", false, null, "USER4@LOCALHOST.COM", "USER4@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBmYBRFos50qlGmEDytkjz2ZNSbPZvKHG2JJHCg/r2YW83LNlhdzsGFXm8GY29LJvA==", null, false, "7daffdc8-0e19-44d5-aefb-72c08e0b409d", null, false, "user4@localhost.com" },
                    { "3f4631bd-f907-4413-b416-ba356312e659", 0, "dd971a83-6333-46c8-be61-b24527252d63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@localhost.com", true, "Mario", "Andretti", false, null, "USER5@LOCALHOST.COM", "USER5@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHbwmg00almsZvZNjJXZ5/ptx+TYaGJ+xjvfF43JD8ILB2dKnd4RvMnkPC528+8/yQ==", null, false, "79a17183-140b-45de-aa82-353dcbe724ea", null, false, "user5@localhost.com" },
                    { "3f4631bd-f907-4414-b416-ba356312e659", 0, "77a9fcb1-060a-4bbf-8b05-3c7759de9dc0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@localhost.com", true, "Scott", "Bloomquist", false, null, "USER6@LOCALHOST.COM", "USER6@LOCALHOST.COM", "AQAAAAEAACcQAAAAED1uXmhpm3lMYGfGsUVMfmtuS+cpiPPGc2a3HSEV/2ZEy5MZ4MVUi+1R7hfIn8Vi2g==", null, false, "1a080d58-2c02-4f09-add2-103791632a04", null, false, "use6r@localhost.com" },
                    { "3f4631bd-f907-4415-b416-ba356312e659", 0, "e23a9f8b-7529-44e2-bf71-3fcaa3b50b66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@localhost.com", true, "John", "Force", false, null, "USER7@LOCALHOST.COM", "USER7@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPS10A7eol7+f3XMX2NJoZPjcmxFV0UW9ZkUdrj1mfOPDiJO85KXRifBiTfmn0lN8A==", null, false, "34f6b24f-7b4e-4a93-8952-24cd1275e939", null, false, "user7@localhost.com" },
                    { "3f4631bd-f907-4416-b416-ba356312e659", 0, "757d46db-6a0e-42d8-9cf7-1155f1108426", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@localhost.com", true, "Don", "Prudhomme", false, null, "USER8@LOCALHOST.COM", "USER8@LOCALHOST.COM", "AQAAAAEAACcQAAAAENCaLm2HcQKMShN10fWZrVR9EF1CjD/r6HveTdsZd25hP9sEjMOqHZKFs9sJ3JBhGw==", null, false, "94bcf989-6988-4c1d-8cfd-459a80ff09d4", null, false, "user8@localhost.com" },
                    { "3f4631bd-f907-4417-b416-ba356312e659", 0, "1dab6789-5a90-4a86-b8af-82499ed7e26a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@localhost.com", true, "Tom", "McEwen", false, null, "USER9@LOCALHOST.COM", "USER9@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP5nSNJ0al3kIZOLvA+IOAgxyCtxPIYchgtd/Bpd4D/rXieo4cP4rReeBY6m93fOtQ==", null, false, "3ff79d98-5b11-42c9-8316-a94e1e0eb625", null, false, "user9@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4410-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4411-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4412-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4413-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4414-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4415-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4416-b416-ba356312e659" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4417-b416-ba356312e659" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4410-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4411-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4412-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4413-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4414-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4415-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4416-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "3f4631bd-f907-4417-b416-ba356312e659" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4410-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4411-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4412-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4413-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4414-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4415-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4416-b416-ba356312e659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4417-b416-ba356312e659");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
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
                value: "be9b44dd-cb6e-49db-823e-90d5d1a2f55e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c190f44f-5d9a-446e-b21e-e2446ffc2353");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "Email", "Firstname", "Lastname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb88be60-1340-4805-bee7-934d5b848964", "user@localhost.com", "System", "User", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEWn9GI+n/C4w3z7xR2Hhs1gSIbMU/JXYpJmPCPT3veB6VWOz5A1mFYXGl22i4Z/hw==", "a6e2c344-3ab2-4208-a30c-19470bd19339", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621b5e6a-9743-46cd-91fe-1ba0e2d699d8", "AQAAAAEAACcQAAAAEKx4urlwFeYdxAg8k6gLI6BPbDu2wXGwe9oktEBFOUdR34n52btMWnE0okHWjWrPmw==", "18e9f13b-a452-4dfc-8d88-21974dc7767d" });
        }
    }
}
