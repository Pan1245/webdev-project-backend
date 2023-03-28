using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace houseofgriffinapi.Migrations
{
    /// <inheritdoc />
    public partial class fixStaff5 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_takenByEAId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_takenByEPId",
                table: "PrivateRegistrationRequests");

            migrationBuilder.DropIndex(
                name: "IX_PrivateRegistrationRequests_takenByOAId",
                table: "PrivateRegistrationRequests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_takenByEAId",
                table: "PrivateRegistrationRequests",
                column: "takenByEAId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_takenByEPId",
                table: "PrivateRegistrationRequests",
                column: "takenByEPId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateRegistrationRequests_takenByOAId",
                table: "PrivateRegistrationRequests",
                column: "takenByOAId");

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
    }
}
