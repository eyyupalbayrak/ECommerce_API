using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce_API.Migrations
{
    /// <inheritdoc />
    public partial class RevizeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Users",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "CreateDate");
        }
    }
}
