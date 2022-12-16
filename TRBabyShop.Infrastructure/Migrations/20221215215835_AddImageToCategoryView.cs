using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddImageToCategoryView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 7,
                column: "Image",
                value: "https://media.istockphoto.com/id/1306729572/vector/cute-baby-boy-sitting-on-floor-and-reaching-out-to-a-huge-bottle-of-milk.jpg?s=612x612&w=is&k=20&c=KN4ox3aQonjNxZJAeqT9IoPvWyPh6aep1VyfN0sUE0c=");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a2abc-d6e9-4333-a560-989dc89f5797",
                column: "ConcurrencyStamp",
                value: "d0e1457d-872c-49dd-a1f9-e91218bcaa76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                column: "ConcurrencyStamp",
                value: "e8274bfa-348d-4e9e-86f1-fd8d608690ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e631f2b1-5918-410a-a627-167fd767fa19", "AQAAAAEAACcQAAAAEMzpSkKWLR78Lxzw6dmjOaH1huaQwb+DcCe0SC5STN+9tu1C2ejzyJLo/I4UqeWVTg==", "ad013d97-9301-45c9-9284-55068bcb6afc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ad4dd07-6386-4862-8c67-aa48bbd0ae65", "AQAAAAEAACcQAAAAEMEH8LU/JV8Fdt6agQcrceqV5DBcn7C7yAok7cTaAb5MRMP/u+FFdS2jaryiLtYCPQ==", "3e044854-191f-4d1b-826a-667ba3a26500" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2cb9c7c-df09-4e3f-af54-28057fc357bf", "AQAAAAEAACcQAAAAECzg0RjGsEqjkOR6OEvCL7/Ez85Cu8+Ho14NNfjAPQzqEg+ahn62t4ic3ITdimK2rQ==", "2800014f-41c1-4949-bdc4-440b419bc28a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1281b5d0-4aff-492d-b299-7d22cff26562", "AQAAAAEAACcQAAAAENI7IwXs9twnH9TmX80pmGW6Hgq6R5Wifzw8ek0lcmFwbVGRJZosf4vEj6CdRbC0gQ==", "e4e3cb7a-b759-4cf1-ba05-5344b7ad6cbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a577a26d-1e61-4809-8fe7-4611496540a3", "AQAAAAEAACcQAAAAECAXUI7mMv8aZfRpaz8yhqYiYzuGgBSJGvACpaw4yvGuGH9hRzXhiOBs/Ihhx3EJSg==", "ec237b89-e9bf-4e1f-aac1-61237e52336c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://www.ucsfbenioffchildrens.org/-/media/project/ucsf/ucsf-bch/images/education/hero/faq-baby-bottle-weaning-2x.jpg");
        }
    }
}
