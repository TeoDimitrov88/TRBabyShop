using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddImageToCategoryView2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.chiccousa.com/on/demandware.static/-/Sites-Chicco-Library/default/dw8c761443/images/baby-talk/keyfit-30.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a2abc-d6e9-4333-a560-989dc89f5797",
                column: "ConcurrencyStamp",
                value: "5218c43a-0ee2-49b5-852e-c3ae8af7986f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                column: "ConcurrencyStamp",
                value: "b1648b4e-e991-424c-88b4-a57656e67a1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d172627-6d3b-4c2c-89d9-740844b68cf2", "AQAAAAEAACcQAAAAEAD88kgc0CPKqvKw12kJzqmjBtneapH27JnWQe5GKeLOMHAo1CnOq4Q0gRDRhq3AaQ==", "9a6dbd8b-cc9d-4933-9131-7e1c10926118" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6666985-7be8-4821-a860-4e05da553a01", "AQAAAAEAACcQAAAAEGb0xC3ejpXjarR3XhwA1t0p2PLasx5VzioJnd0ahpIzyZrANae6qJWE0zrmjLwopA==", "bbddbac7-6e57-4300-8344-e364c9aa5d54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0abecc8b-db35-4709-a30c-0cc0a00777d7", "AQAAAAEAACcQAAAAEAK5Jx28qRiP6jfUnYIkRZ2CBloDFBOfYO6kvrE9yvcnFewo2bqUIV48EPw7DpCAbw==", "dab9f57a-b1f1-4786-9ed1-c23a3f5ddb8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a45f8d31-3206-45a8-bd0d-c614030141b3", "AQAAAAEAACcQAAAAEEX7HvisQlkBE6FDqTD7SuV2lWZA/TXUDBdPuFFdD/1aMl2DflglQvYOmiFf3Kj+Ig==", "c9983036-4d88-4ff9-a4c5-f316cef78c01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad44dbb0-0c86-4a50-b922-e3daab03dee5", "AQAAAAEAACcQAAAAEEgqDbtnIppHDml732mYO1ko/JRHnCfYhfR+c05JZ3ojuvLPuGDcyPSEfJW48vXBQQ==", "e83be835-f752-4e44-8f77-5f50ffbbd7cf" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.parents.com/thmb/5RJiL_DZxbM0n7aUhJVUncYXL1c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/shutterstock_82716994-17fc260461b54a568e8ee566c9837423.jpg");
        }
    }
}
