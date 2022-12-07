using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1163da51-2369-4b12-aef5-86c360e358de", 0, "f8e79fbc-a52f-4d36-b428-a85b1aa219fc", "admin@abv.bg", false, false, null, "ADMIN@abv.bg", "ADMIN", null, null, false, "c79c2210-3b05-4291-be55-8cce54eba711", false, "admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b711aa94-57ee-48bf-b05d-a9db9f638975", "AQAAAAEAACcQAAAAEChCdtSDylh418vZyQ0nNlSlJzgExj48MfT7No9FG2qsRohA0GglL3O6/hoG7KjK8g==", "f442c22d-2553-44a3-88fe-3c969444b94c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7267e3a-56c5-4473-9419-a907a26d2ba8", "37262b59-cf72-4f56-915d-fbbb690e9a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "180254f7-ef1b-4be3-8827-5c701bfd1f88", "68d33cdf-de14-4244-9183-c562c7df45bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79381bc8-a8ba-4576-b5a3-cfafcf22a66a", "c7246f16-d4d2-4892-8790-fdb45dd4b14a" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 6, 17, 14, 46, 161, DateTimeKind.Local).AddTicks(7673));
        }
    }
}
