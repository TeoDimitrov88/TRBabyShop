using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class UpdateAdminUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3f6f193-cfe5-414e-a7a3-692420984215", "AQAAAAEAACcQAAAAEDTej2grzvkRL9iaVYliYJo+8bHL8qapgYWOFDi/kRTRU/fhBPu/CIjYLg9JYDJjqQ==", "491ff3dd-86ca-47b3-bff8-fb5f02f97b1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "42534566-3b5f-43ab-9697-470a01f098bc", "ea4c8c2b-e93d-48d1-9a72-9cb2110842e9", "admin12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70e495fd-7c61-4666-9212-16882761678e", "51c3d253-fd12-455e-af77-a4ce293f90d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0dc3ff30-f538-46be-b754-77e1211ae963", "3f354bf0-0a44-44cc-9302-5a4790c1282a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1a22b38-d5ab-4e9c-84ee-c88e9867f5fa", "7e9e6725-496d-4068-a762-9c4c0b54485f" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 41, 43, 946, DateTimeKind.Local).AddTicks(4231));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6277d88d-9561-4577-88aa-7b524879e593", "AQAAAAEAACcQAAAAENB3O6ix7t6Lk69EbfJqlobWLlZDQp+EnFO8H9+Vu3vinLGl+XN/NH6h8V70quwAEg==", "9b5aec28-a384-4ceb-b9be-ef65c9851968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "6fc62375-87ad-4d59-996c-05472f9d1db4", "227087d8-0707-4f33-afcc-b736492ca8b3", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6348c9e1-3201-4755-831a-e23f6e092be5", "6aca3d0c-b2c9-419f-94e3-2db63cf5db72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "660ba10e-1292-4cc6-afaa-9157259cc91f", "96837b0e-34cb-49c8-a908-58738a5e02b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1af94bb1-9ca1-473b-83b2-77cd88b9fc32", "939a7dc5-85bb-4221-be09-14142df1dde9" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 20, 32, 9, 686, DateTimeKind.Local).AddTicks(8112));
        }
    }
}
