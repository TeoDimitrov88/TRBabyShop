using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15c52ed-0b17-4344-bf5b-12e5136ad796", "AQAAAAEAACcQAAAAEEm1zY5UlFhg7pnKKQoiEXDyTitorSU3jiqiK3njiaNrYW4ipjWptAJ/b9oKIxpKaQ==", "573c1584-b35d-45e6-bec4-43a3f9c0d031" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa1afd36-9f3b-4ccb-a506-5dea85445501", "2c1215d2-920b-4732-bd6b-bee2579dd9d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c65765f4-5ae7-4edc-822b-8c642c928465", "b0441445-cd14-468c-8b5c-29b00949732a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e775e06f-edf4-487b-86ee-157d20f6a069", "f2344b50-da03-4f83-9ae1-d404ed595bdf" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 23, 28, 38, 326, DateTimeKind.Local).AddTicks(6616));
        }
    }
}
