using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeknoLabs.Crm.Persistance.Migrations.ClientDb
{
    /// <inheritdoc />
    public partial class companyId_to_clientId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "UniformChartOfAccount",
                newName: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "UniformChartOfAccount",
                newName: "CompanyId");
        }
    }
}
