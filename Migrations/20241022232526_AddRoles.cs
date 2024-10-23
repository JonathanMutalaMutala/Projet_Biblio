using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_Biblio.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126de5ee-a527-4781-90ae-088f50c4e5bb", null, "IdentityRole", "Member", "MEMBER" },
                    { "237f8bf4-22ef-4f81-8375-92b5516ae1a0", null, "IdentityRole", "Employee", "EMPLOYEE" },
                    { "33839dce-3f1d-4460-8c35-cec7aeac4608", null, "IdentityRole", "Admin", "ADMIN" },
                    { "524e1a90-a13f-4bc1-bea8-b062539bee1c", null, "IdentityRole", "Librarian", "LIBRARIAN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126de5ee-a527-4781-90ae-088f50c4e5bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "237f8bf4-22ef-4f81-8375-92b5516ae1a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33839dce-3f1d-4460-8c35-cec7aeac4608");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524e1a90-a13f-4bc1-bea8-b062539bee1c");
        }
    }
}
