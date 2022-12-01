using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddAreas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc69e98-6819-49f1-ae41-2027c93f722e", "AQAAAAEAACcQAAAAEDkt6zMAF2gOnrcwEkSvO1xrEf9TUT+/6fIUCdzIadee07Ny/1Sn5yypT8pTkeoupA==", "5ae06674-b4fb-49cc-bc13-a53bd41decd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5337db5-e985-4c86-b6cd-97fb51897aa4", "3bb3ae39-a924-4645-ab84-01512c3668b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac1e561e-8c45-4e34-b8be-55808af86847", "3e0e90f1-dc1b-4729-a57a-9905215ecdf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3699e1be-de9e-414a-89f9-fd0c0b77e9a9", "f449799c-65fb-475f-bcff-7d3b85ffd21b" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 30, 15, 35, 51, 17, DateTimeKind.Local).AddTicks(5813));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62e0e9a1-afaf-4782-bc06-8b60e93b2471", "AQAAAAEAACcQAAAAEJIk3W8FYq2WX6wkRXpqyac+IieyVW4uSiVcl3AHJyCcywv/1bXHvNwA7aUAtIJKSg==", "50191b0a-354f-4eed-be8b-be21627b1ed6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4a73f47-29e2-49fd-bc55-82d4587bb507", "2bb5c7a5-8aee-473a-b5a3-d5cf7d45d96e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "601ccb42-1076-4abd-aafc-23ecfe7d3f1e", "7447cb5d-c3ca-4b49-9668-ad8a3e00c808" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9ed672a-7665-4d69-85a5-bd35e0ada8ff", "e485e664-b634-4be2-a1f1-5fd9d5b32be8" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 23, 19, 54, 37, 595, DateTimeKind.Local).AddTicks(5343));
        }
    }
}
