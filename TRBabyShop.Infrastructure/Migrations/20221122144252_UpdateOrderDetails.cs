using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class UpdateOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe7d772-624d-434b-83e8-3e173bbccb0b", "AQAAAAEAACcQAAAAEJ9SphDMnBLNRDq9/QPS8jPC7Cge6ow/NWKLQpqXWsrOWQTrCbAdqyomT+Pg5Uhvsg==", "3396c558-d97c-4006-975c-e838e96248fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20cd92e3-8dad-4d3c-b02e-908699dec4f7", "0683415c-adaa-4f40-8f67-64c8fb140517" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a3f3524-6794-4414-9896-1ccc527ccfc4", "c012c480-989d-4c17-bc11-4b19095fe753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b54ad24b-6e1b-40f4-8e92-95c41ce9eb91", "05d5f375-cdf4-4e46-b624-28e831486052" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 16, 42, 52, 132, DateTimeKind.Local).AddTicks(527));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "698a0285-c887-45e4-9a96-a8d15fe6e931", "AQAAAAEAACcQAAAAEG3Q78pGawXX2rY7w0vjJvtUoGeP8vnk4hLRLl/q0IALS1BD+m4gk9metTti4oHMug==", "0f02c0d8-cc3f-4526-9da3-e8ba93f7f320" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f767dce0-66a5-4e42-a1f9-60a4195a60a3", "5c7f99bc-af16-4410-aaf7-5b23b1f6c52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6de218c-e764-44d5-be1a-7ea1ae785f97", "83027482-17f7-4920-a697-ad03cb318fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0259cb15-26f3-4707-89fa-8b7c11265078", "940887ea-f02a-4c49-a5d7-25eb7d335772" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 22, 12, 42, 45, 328, DateTimeKind.Local).AddTicks(6928));
        }
    }
}
