using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseofgriffinapi.Migrations
{
    /// <inheritdoc />
    public partial class fixStaff4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_EAs_EAid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_EPs_EPid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_OAs_OAid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_EAid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_EPid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_OAid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "EAid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "EPid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "OAid",
                table: "PrivateRegistrationRequests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EAid",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EPid",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OAid",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_EAid",
                table: "PrivateRegistrationRequests",
                column: "EAid");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_EPid",
                table: "PrivateRegistrationRequests",
                column: "EPid");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_OAid",
                table: "PrivateRegistrationRequests",
                column: "OAid");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_EAs_EAid",
                table: "PrivateRegistrationRequests",
                column: "EAid",
                principalTable: "EAs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_EPs_EPid",
                table: "PrivateRegistrationRequests",
                column: "EPid",
                principalTable: "EPs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_OAs_OAid",
                table: "PrivateRegistrationRequests",
                column: "OAid",
                principalTable: "OAs",
                principalColumn: "id");
        }
    }
}
