using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projet_Biblio.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "011edf74-2c6e-4513-a965-4191f34405a9", 0, "51d5031f-b831-43fa-b798-74a7d5671e8b", "User", "member@localhost.com", true, "Member", true, "Member", false, null, "MEMBER@LOCALHOST.COM", "MEMBER", "AQAAAAIAAYagAAAAEFY0cSqu54h5GZZn606vFLoVdmyL06jptRw2/vFeufvvQLhvvRXrI2PI3mOnllwa+w==", null, false, "3a6a45d7-8009-43ba-807d-56c849e7d95f", false, "Member" },
                    { "53965792-59c5-4d25-b6fa-c096541856d0", 0, "20d18d93-3d2a-4501-bec4-a755930cafa8", "User", "admin@localhost.com", true, "System", true, "Admin", false, null, "ADMIN@LOCALHOST.COM", "Admin", "AQAAAAIAAYagAAAAENSDbMg9O0QhTUES2zlqpNUiNDj8SwC49uMyRXyybnR1Qn50x4YlkKhEhaU46Jm/1A==", null, false, "d3dd53df-8fb9-4d9a-a05a-ae82b5e5b816", false, "Admin" },
                    { "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4", 0, "50a3c59b-bafe-4942-b5ae-9821d0c362e3", "User", "librarian@localhost.com", true, "librarian", true, "librarian", false, null, "LIBRARIAN@LOCALHOST.COM", "LIBRARIAN", "AQAAAAIAAYagAAAAEN7H39ENovdb1s8iOGDTN9/n75R4wughRFJt79f759Psgokxsy6eZl8yb0sfcIAC5w==", null, false, "0cbc99e8-83bb-4376-be61-b056de551789", false, "librarian" },
                    { "da1ce89a-476d-46d0-897e-ee7aa6576179", 0, "b49aa835-6b05-4597-9cda-878da4cb2d89", "User", "employee@localhost.com", true, "Employee", true, "Employee", false, null, "EMPLOYEE@LOCALHOST.COM", "EMPLOYEE", "AQAAAAIAAYagAAAAEHVM+g6Bh/QUBRXwbJlKlbxn0EuyiGaIBa5GWwNRr9Kzfh0kqGFtarqaUDylJVpTnQ==", null, false, "2f33bb40-6f5a-40fc-b494-320f6ef88830", false, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "126de5ee-a527-4781-90ae-088f50c4e5bb", "011edf74-2c6e-4513-a965-4191f34405a9" },
                    { "33839dce-3f1d-4460-8c35-cec7aeac4608", "53965792-59c5-4d25-b6fa-c096541856d0" },
                    { "524e1a90-a13f-4bc1-bea8-b062539bee1c", "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4" },
                    { "237f8bf4-22ef-4f81-8375-92b5516ae1a0", "da1ce89a-476d-46d0-897e-ee7aa6576179" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "126de5ee-a527-4781-90ae-088f50c4e5bb", "011edf74-2c6e-4513-a965-4191f34405a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33839dce-3f1d-4460-8c35-cec7aeac4608", "53965792-59c5-4d25-b6fa-c096541856d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "524e1a90-a13f-4bc1-bea8-b062539bee1c", "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "237f8bf4-22ef-4f81-8375-92b5516ae1a0", "da1ce89a-476d-46d0-897e-ee7aa6576179" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "011edf74-2c6e-4513-a965-4191f34405a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53965792-59c5-4d25-b6fa-c096541856d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c10e1a0e-9b8f-407e-8f38-f9ad7a8028d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da1ce89a-476d-46d0-897e-ee7aa6576179");
        }
    }
}
