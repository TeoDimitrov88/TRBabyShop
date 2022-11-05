using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class CreateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04ba4719-a5ce-478d-b36d-169ffe19e118", 0, "ac41ff9d-6a5e-4100-8fa0-78ea0a1c6932", "teo88@abv.bg", false, false, null, "teo88@abv.bg", "teodor88", "AQAAAAEAACcQAAAAEC74VagqeN7KkC4ZN0xzywmkDl63rQO0xomWxbyHf18uYl2auSBb2KnJyroecKixrg==", null, false, "40af0638-201d-44b3-9368-895cf12ddc40", false, "teodor88" },
                    { "c225f1de-8898-473c-8b8d-484a5034beea", 0, "a6fff621-a8fd-4a8d-92be-72e9122a23a2", "tina93@abv.bg", false, false, null, "tina93@abv.bg", "tina93", null, null, false, "16dec308-796e-4b51-a819-5fee41a0989a", false, "tina93" },
                    { "cd0f2b40-9353-405c-ae22-c1097419f287", 0, "ac2bf691-10bc-42f3-8898-f3d33dbe0d43", "hristo80@abv.bg", false, false, null, "hristo80@abv.bg", "hristo80", null, null, false, "e50976e4-844d-450e-a6aa-9c802871336d", false, "hristo80" },
                    { "d381c77f-aabf-46bd-80e3-cf9ee84a668b", 0, "746e9b06-667b-45cd-bbd6-cdf4e3536df0", "ivan89@abv.bg", false, false, null, "ivan89@abv.bg", "ivan89", null, null, false, "42971d98-18a3-4888-9621-9d8c909cf46b", false, "ivan89" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b");
        }
    }
}
