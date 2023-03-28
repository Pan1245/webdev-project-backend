using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseofgriffinapi.Migrations
{
    /// <inheritdoc />
    public partial class fixStaff2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEAId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEPId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByOAId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.AddColumn<int>(
                name: "Staffid",
                table: "PrivateRegistrationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_Staffid",
                table: "PrivateRegistrationRequests",
                column: "Staffid");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_Staffid",
                table: "PrivateRegistrationRequests",
                column: "Staffid",
                principalTable: "Staffs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEAId",
                table: "PrivateRegistrationRequests",
                column: "takenByEAId",
                principalTable: "Staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEPId",
                table: "PrivateRegistrationRequests",
                column: "takenByEPId",
                principalTable: "Staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByOAId",
                table: "PrivateRegistrationRequests",
                column: "takenByOAId",
                principalTable: "Staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_Staffid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEAId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEPId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByOAId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_Staffid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropColumn(
                name: "Staffid",
                table: "PrivateRegistrationRequests");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEAId",
                table: "PrivateRegistrationRequests",
                column: "takenByEAId",
                principalTable: "Staffs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByEPId",
                table: "PrivateRegistrationRequests",
                column: "takenByEPId",
                principalTable: "Staffs",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateRegistrationRequests_Staffs_takenByOAId",
                table: "PrivateRegistrationRequests",
                column: "takenByOAId",
                principalTable: "Staffs",
                principalColumn: "id");
        }
    }
}
