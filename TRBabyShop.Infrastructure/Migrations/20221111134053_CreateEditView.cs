using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class CreateEditView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbbbff1c-3571-4a74-a495-5b807a8f53c7", "AQAAAAEAACcQAAAAENXb3reQRI5z+3GH2YVtCnRsCVM2QQKq8vWdDJwDciGjUUVHYK0zpHQcP+BISM4e2g==", "d30c68bd-cdb2-498c-9e89-81629c55da67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85d8f619-26cb-496d-a7d1-b0db134beb17", "ad044e51-bde2-47c0-be39-7855a974a590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48e6f68f-0c6b-4a5e-8607-2f70f3dfa076", "e3c3e4b1-461a-49b6-8f6d-116fdc1de570" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1a3dd96-6b71-4fc3-9d3b-d88d4c63d031", "f3e1f735-2bd8-4c37-b54b-b29d54ecd51c" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(235));
        }
    }
}
