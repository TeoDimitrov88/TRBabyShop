using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class ChangeReviewEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fc62375-87ad-4d59-996c-05472f9d1db4", "227087d8-0707-4f33-afcc-b736492ca8b3" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80f567a0-fe7b-4bbf-8511-5ce956cd00ca", "AQAAAAEAACcQAAAAEJMAw6UWm028lTcbS8ZXBI6MaL54586APvtFracUQhK/MkpAH/kr5wWe+ugVFYsABA==", "85847a85-e856-478a-b94b-4eaf8d698673" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8e79fbc-a52f-4d36-b428-a85b1aa219fc", "c79c2210-3b05-4291-be55-8cce54eba711" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10303722-ac53-4a95-aab6-cec75f0728c2", "a39a0942-9d7a-416c-8a37-8a9ba8a0b982" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91c0fa86-fc97-4bb0-8ec1-e3b5598bc6c2", "b932217d-f33d-4b25-bb13-d323a3a0ee6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "790fb3e1-8670-41f9-a05b-f113a86439d2", "9c26db5e-151d-48ee-b0fa-1a2f7eacbbcb" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 15, 43, 7, 712, DateTimeKind.Local).AddTicks(8475));
        }
    }
}
