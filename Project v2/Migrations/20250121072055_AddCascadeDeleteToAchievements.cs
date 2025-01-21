using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_v2.Migrations
{
    /// <inheritdoc />
    public partial class AddCascadeDeleteToAchievements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "nba");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Teams",
                newSchema: "nba");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Players",
                newSchema: "nba");

            migrationBuilder.RenameTable(
                name: "Achievements",
                newName: "Achievements",
                newSchema: "nba");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "nba",
                table: "Teams",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "nba",
                table: "Teams",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "nba",
                table: "Players",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "nba",
                table: "Players",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Teamid",
                schema: "nba",
                table: "Achievements",
                newName: "teamid");

            migrationBuilder.RenameColumn(
                name: "Playerid",
                schema: "nba",
                table: "Achievements",
                newName: "playerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "nba",
                table: "Achievements",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Achieve_name",
                schema: "nba",
                table: "Achievements",
                newName: "achievename");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "nba",
                table: "Players",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Teams",
                schema: "nba",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "Players",
                schema: "nba",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "Achievements",
                schema: "nba",
                newName: "Achievements");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Teams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teams",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Players",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Players",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "teamid",
                table: "Achievements",
                newName: "Teamid");

            migrationBuilder.RenameColumn(
                name: "playerid",
                table: "Achievements",
                newName: "Playerid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Achievements",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "achievename",
                table: "Achievements",
                newName: "Achieve_name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);
        }
    }
}
