using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ffd40707-8091-4ae6-a266-522de2f571bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5685044a-9ddc-40b9-84d1-6581d5ec78d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cac2fce0-1174-4535-b4f7-8ef0eecaef13", "AQAAAAEAACcQAAAAEFYwSAJW0Q2TqbaBSvZtlytvUXJ1xPUrA0/BoWdeVOxuvaX/rtNc6jBkV73f39jOOg==", "9abf1b7c-7a04-43de-82cd-3bcf772ac37d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e4ac2aa-5db5-4376-a3b8-37cfa2fb0788", "AQAAAAEAACcQAAAAEHCfF009gGfl5ET1K6xr11trVPPdRtFSJ2E2BHphhH/+c3YgvnW76F0iuKOGpNWcMg==", "96fb616b-8d3f-47a6-ac59-76142fa8ff0f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8c484422-4748-4f49-a9ba-d4fd6f08a2c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9ba075ae-2eda-48e2-bc97-2c5c3d5fb527");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3e6ad5-8601-4292-8b13-9250c58ab029", "AQAAAAEAACcQAAAAEBiVlCEKrEYUH8y70GFBiCVIb7bzv/0aibgGPMOVMx+exSXwALu0NTrDeSl/k+KZLA==", "0411595c-f3d8-42eb-a212-ae3153b59b24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6553365-cfbc-47dd-b3ad-2d3223379045", "AQAAAAEAACcQAAAAEOCpPcJcgpNBPALvlHNouZ1kPySVjw/LMU9T3l1wGeDwOYyl2TVlCgXTXc/PhySE2w==", "1e93deac-eac8-4175-acbb-705f901a9969" });
        }
    }
}
