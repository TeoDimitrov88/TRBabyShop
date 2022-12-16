using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddImageToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                keyValue: 1,
                column: "Image",
                value: "https://media.istockphoto.com/id/509348476/vector/cute-little-baby-reading-book.jpg?s=612x612&w=0&k=20&c=a3vUKKQBlBzc7HDz3fikel_RAPQ3EIzZIbyS2_7xG28=");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.parents.com/thmb/5RJiL_DZxbM0n7aUhJVUncYXL1c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/shutterstock_82716994-17fc260461b54a568e8ee566c9837423.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://metafields-manager-by-hulkapps.s3-accelerate.amazonaws.com/uploads/yookidoo-shop.myshopify.com/1634474533-Bath_Toys_375X375.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://kdvr.com/wp-content/uploads/sites/11/2022/08/1040x585-2021-0916-best-baby-bottle-sterilizers-065dfd.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://i.pcmag.com/imagery/reviews/01szgG5mr7x5xqFnO8xvyQo-1..v1629209217.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://www.silentnight.co.uk/pub/media/catalog/product/b/a/baby-sleep-bag-1.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://www.ucsfbenioffchildrens.org/-/media/project/ucsf/ucsf-bch/images/education/hero/faq-baby-bottle-weaning-2x.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e46a2abc-d6e9-4333-a560-989dc89f5797",
                column: "ConcurrencyStamp",
                value: "3c11d546-b3de-4339-90ec-a6d4e3685b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                column: "ConcurrencyStamp",
                value: "8a08ec17-5c95-4a13-9372-4b65eb05f596");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b424df-10ea-40dc-ad2d-f9f888c65092", "AQAAAAEAACcQAAAAEDegVuqTC9FB3kvnarza1/1CIbOvnYI8Q5oGdJXVezY9QxhlQhbmCIhyHsPgtxvHtQ==", "c3e56b6c-d10e-4e58-949d-87b283ec0a66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95449a3-c60a-4bba-af6c-5513535663ad", "AQAAAAEAACcQAAAAEJx9mr31/9BCIjEdx+uyEQFWbDnLIGSLxPX9sNMCQZ+5D67hZYmskZNjzt8KQbZhag==", "2827a33a-2d95-47a3-9fac-1d3555163633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52db6c07-2eb9-4df7-b6b9-3a0687f35f98", "AQAAAAEAACcQAAAAEM3t2ZZUi84CUY0nZbBZ44XSLuPzYHTjnDzLZPtjpuaVEJ6L2MRuhRRkqcQYRMoSEA==", "d08be54c-9653-4542-ad0c-b4acbf7969f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cb0fbb6-e8cc-4630-814c-abe6c189300c", "AQAAAAEAACcQAAAAEAvR+8OIBfcu5ZKfykRiS16T0xackwet2naGDoNtSgd6xWgRMvy4TrOEkn8rLG3dFw==", "536f38d6-9af4-4f54-b600-d15168dda991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "869cba6e-df31-4857-b4d3-9931b6ea67be", "AQAAAAEAACcQAAAAEHh2EvVuWKt1Xupn+kkoUIzCZF1Cu93gOI4StJdlzITCl+toyQKP0ZiUSllL/UW5GQ==", "eca5b4b6-76f6-4cb5-a74b-6deb488ce6f1" });
        }
    }
}
