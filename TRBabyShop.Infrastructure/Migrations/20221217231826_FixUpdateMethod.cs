using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class FixUpdateMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a2abc-d6e9-4333-a560-989dc89f5797",
                column: "ConcurrencyStamp",
                value: "14de3694-fc0e-473d-a067-43664787403b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                column: "ConcurrencyStamp",
                value: "58d1a093-5322-4285-b6f9-88e4da9d8dc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b47d31c-a6a3-43a8-8500-c7e93740c1bc", "AQAAAAEAACcQAAAAEDgRkVnA9BGBmH3p54mHL56Jwhmxhn7AGux0fSItMSmHIdFEfLoFQOzWopSnGQgiQA==", "a31c3ecb-cde9-4d39-82ba-b0022f2ff63e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f16698b-ce37-4a14-aa3d-ba69e7228e8b", "AQAAAAEAACcQAAAAEFwTuITW3zxz+BfKd8NRtSZPCZiRIbn9U54EAgJmJxvCTNQHwX4Tt6jgMzJP/MBbRg==", "944d817d-bb70-4f8b-a751-3fcf872d05e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d330ee7c-9c17-43fd-87c6-6dc9d4dc8018", "AQAAAAEAACcQAAAAENd3ntJWm13f5r0Ryc3Efhxm72wYqWxtIA9BUDVgDlHKg83T7ZYtr45C13ej8k9KAg==", "7e67e960-f8f8-47fb-a4ec-d78e5295e2c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "395b084b-ea52-4d51-8d57-c3f384444c21", "AQAAAAEAACcQAAAAEBJ8pKp6+KA4RIko7m94/SD/KZQRw11Pwh2rM41+YBnXvsxP4TCnUOo7bYLVcuvDeg==", "1243faeb-8814-4e37-9592-c42b40673d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c82c250d-0e01-4cd0-b822-fddea6ceb5f5", "AQAAAAEAACcQAAAAENZeuSpPU/XSqqrhIhSNyaoGyfUX/tPw+5i8eO1KUdVR6Podevyq5MrNlk7FpwEGFA==", "0ba9009c-bcb2-4604-8f45-e479e510e4ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a2abc-d6e9-4333-a560-989dc89f5797",
                column: "ConcurrencyStamp",
                value: "c3cda750-3e20-4b98-9b90-7354a1e74cff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                column: "ConcurrencyStamp",
                value: "dfde98f5-cdf4-49a9-bfe6-0d11e61c2825");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "862759fb-6b03-48fb-ad23-7ac2f9d147c2", "AQAAAAEAACcQAAAAENkYrJxHOxyKG99As70xjVfDujFyOW0pJ44BKa+kuD2Yupc1PohvZVuAwTrII6VEaQ==", "b8fc6b0c-ff74-4ba7-84a0-afd0f1ef04e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be6a1fb7-e4c7-40df-b85d-c1f9abc7977e", "AQAAAAEAACcQAAAAEIrNsJwGRB7ymXQSarkzBP5kUj0ejkUxJj+aO9gUmhOq2nBzwXBUfho2Qzly1tcx2A==", "b1944206-9164-4ce0-94f0-d0def42ed225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b31d6c34-d845-4ac8-a487-57e23ec59799", "AQAAAAEAACcQAAAAEBB82wxydwav+hu+xtE/JiwilGYKJqT/CwW2ZMLYOi0rZQ0hXGYK+cWZemky0PSRgg==", "b8393506-2037-4832-98e0-9730f15a9430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7c89149-89c1-4190-b3a3-7d5d4b3202bf", "AQAAAAEAACcQAAAAEO+FL0F5NnL5TEs0F1s64k3fraDF7R2IaYzN0MOUNg/7rOqH2ojVkcGB0If1mNhptg==", "b5390009-2199-4718-adf2-c2314b07b4ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfae957a-2d65-408f-a6bc-7899f4d07ff3", "AQAAAAEAACcQAAAAECyi92oQJnKWkKmFNbIVXeUKMaygVI11DAa5dIKiZoSUZbs+mWSbtYSgWWAqDN+Mnw==", "d10fb7ca-dd9a-4937-b3b0-1ec25512657d" });
        }
    }
}
