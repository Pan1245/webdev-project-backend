using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseofgriffinapi.Migrations
{
    /// <inheritdoc />
    public partial class createdUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PrivateCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "PrivateCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PrivateClasses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "PrivateClasses",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PrivateCourses");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "PrivateCourses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PrivateClasses");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "PrivateClasses");
        }
    }
}
