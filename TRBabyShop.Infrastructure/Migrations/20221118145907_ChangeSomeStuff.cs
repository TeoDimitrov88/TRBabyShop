using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class ChangeSomeStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f110ed7f-1d8d-482c-a55c-81d367933480", "AQAAAAEAACcQAAAAENEhXlpoPqIVnTGbSOs24NLe4Os7IudEyLOgUF6S3Y9s4HO7OvcYNxegv26e4cbIKA==", "2486c062-834c-4f38-9c51-d49e2aa2ab7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5e37e43-d5e1-43fc-9433-c71326a9826a", "869376e8-0ce7-4184-87f8-899fc089b656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b03fdea6-8d8c-4379-9d1f-5a6b833c34fd", "dc4fb875-c353-43e9-bdf4-08f1f758f1d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46197d42-bd86-4d87-92ba-e770d64909b7", "0b5c2b60-d840-4618-bef3-9955b5e8f631" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 655, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 11, 18, 16, 59, 6, 656, DateTimeKind.Local).AddTicks(574));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
