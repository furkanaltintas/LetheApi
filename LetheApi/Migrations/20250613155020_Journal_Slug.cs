using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetheApi.Migrations
{
    /// <inheritdoc />
    public partial class Journal_Slug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Journals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Journals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: "");

            migrationBuilder.UpdateData(
                table: "Journals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: "");

            migrationBuilder.UpdateData(
                table: "Journals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: "");

            migrationBuilder.UpdateData(
                table: "Journals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Journals");
        }
    }
}
