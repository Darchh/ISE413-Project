using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFull",
                table: "Teams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Points",
                table: "Teams",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Players",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFull",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Teams");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
