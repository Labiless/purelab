using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace purelab.Migrations
{
    /// <inheritdoc />
    public partial class addedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "allPosts",
                newName: "Subtitle");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "allPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "allPosts");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "allPosts",
                newName: "Date");
        }
    }
}
