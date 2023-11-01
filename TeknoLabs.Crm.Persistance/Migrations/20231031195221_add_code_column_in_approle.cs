using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeknoLabs.Crm.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class add_code_column_in_approle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Roles");
        }
    }
}
