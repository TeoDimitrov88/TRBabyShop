using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69943664-8df7-49e1-abf6-75cf73f6f145", "AQAAAAEAACcQAAAAEEf7ey6JECe60dmQVTpSyRotjtX1vmOinr5hGggwH0ErFHa8xM/Fhfu1NYDslSyzMw==", "75761ebb-ce7c-4edf-89e0-3a527b6685e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8146c9a9-3064-4447-9c8a-ca6b6916980a", "4a8a41fb-8c10-44cc-b8cb-74862460213d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "190ddd01-a37d-4cc1-9365-579dcbf4c638", "46da525a-ba3f-4b45-b500-7ee435b6b918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8da4b53c-4ecd-4d82-9aee-4cee0c11fe61", "a5d59512-5dd5-4dba-95e2-c44f973ad081" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/babymoov-babymoov-turbo-pure-steriliser-and-bottle-dryer-blue-33002899701925_1024x1024@2x.jpg?v=1656496367");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a1fb447-783a-4712-9c55-7f239349f59d", "AQAAAAEAACcQAAAAEK+6AiMxkwD4IQN0VaYRhL1szdHmTl4/Zq3GkMJsQvDYkVHvy+tMHkfdbtrCtnyldA==", "73663b11-ff6c-4ea0-89be-e89ab1826854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1869da9e-9dec-4eed-a1cb-8dce2b75e41b", "7cb17eab-6388-4b88-a288-f5b1d49c802f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce6e6e38-3292-41da-99a4-2a916a81c3c7", "adba704f-d6a6-401e-8d68-06a15e980058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03ab69d6-8e58-4709-ae42-9724ec5e2eab", "79be6d62-bcc7-475d-8f66-4b4e07d60794" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-light-up-rainbow-reel-spinning-developmental-tray-toy-6-months-32104676753573_1024x1024@2x.jpg?v=1638282346");
        }
    }
}
