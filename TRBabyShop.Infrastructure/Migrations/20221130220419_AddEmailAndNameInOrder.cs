using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddEmailAndNameInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b7193c2-0fea-4c85-881f-12262f92295d", "AQAAAAEAACcQAAAAEHSUSAx1un04Sec0EZt8d+Fgm6ivvhm0DX4VKwFHDMb47zfV7kUhCVuDPz164PCMug==", "7f3a38d3-3354-44fa-b79c-f40262b2dff1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be2b93ce-6728-4734-bada-ddb2aaa151ef", "b882fd44-1247-417f-95ee-e5308de3053f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "977f6e06-fe8e-4bd0-9eed-ee4d80573e91", "efe7cd89-c558-4976-af01-0efab0888285" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "823b29db-2eab-4d89-a559-509dfff685ac", "a09c183d-709d-4ce5-8c91-60c4fe291d73" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 1, 0, 4, 19, 145, DateTimeKind.Local).AddTicks(7211));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

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
    }
}
