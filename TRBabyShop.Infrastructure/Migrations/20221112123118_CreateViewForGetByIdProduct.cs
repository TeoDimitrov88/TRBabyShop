using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class CreateViewForGetByIdProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91794718-0565-48a1-ae5c-f4ee6eb12750", "AQAAAAEAACcQAAAAEJ2P/bR6DrMne9nDhuM/o/R0EVDK9ERWWkgG1GwF9cbWm6wz2AiiFYHsDAEm26QlYw==", "8f5363c8-bbbb-416c-a9c4-5835c3c1412f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd8bf449-cf7a-430d-a3bd-4bbe85eae2dc", "a7896c7e-f516-4d38-9e42-82dedb06991c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5d5a4e4-1b79-4fad-a0ce-59ba1131f02b", "bd8bb140-dd50-4a41-8913-9f5e8bbb98f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5416374-77c5-41b5-b628-b8b86a655eff", "a97076ed-1fd9-476c-b1cc-1f3f7c35594c" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 12, 14, 31, 17, 506, DateTimeKind.Local).AddTicks(7007));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10d5d772-6860-4438-a7ab-6efb836453b1", "AQAAAAEAACcQAAAAEMGb8VnunWint75OX7x5peCu+WFl4yrYYO2zGqTLT3cOnJrX5kolbsbOhjBDWxyhUQ==", "668be79c-1fb2-4104-bd86-20e57b562113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4d1e473-6704-45ae-bff0-d496e53f6b7b", "ed310907-f849-4de8-be43-7bd57e679e3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eed952fc-30a6-4bcb-b2b1-fafc8a7b6004", "c64755f5-977e-4661-9cf1-7d5fee09506d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3122242f-5545-4d5e-85c2-f02e2c14a67d", "1eedf33c-cf6e-49d0-a587-6db8002d8849" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 540, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 540, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 11, 15, 40, 52, 541, DateTimeKind.Local).AddTicks(36));
        }
    }
}
