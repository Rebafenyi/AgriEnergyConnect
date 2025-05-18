using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriEnergyConnect.Migrations
{
    /// <inheritdoc />
    public partial class RenameProvidersToEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyName", "Phone" },
                values: new object[] { "Tau GreenTech Energy", "011-278-4387" });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyName", "Phone" },
                values: new object[] { "Isfiso AgroSolar Ltd.", "011-973-3518" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyName", "Phone" },
                values: new object[] { "GreenTech Energy", "012-345-6789" });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyName", "Phone" },
                values: new object[] { "AgroSolar Ltd.", "098-765-4321" });
        }
    }
}
