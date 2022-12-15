using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8799a17b-31e4-4349-b710-eac0d54e937c", "AQAAAAEAACcQAAAAEMpMLQbF3Utrbiyh5eiTkk9CIWAY/ULC3+rHOlmsQV+W0e7norabfH2n3yKFLHa6dg==", "fc5d43db-27eb-41dd-939a-3b8718ca56b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ff262c3-05ca-425d-a448-d0e4912dfd65", "669342c3-472f-4331-a291-0afc14cf1c2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d3448e8-a53d-4476-9417-1bb0dba3951f", "992643f3-9225-4051-825c-a3e4b267b969" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f0d2b30-a0ee-4422-a855-b5241b638a51", "f087770c-8819-4c39-ba65-056a85137005" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f18093f2-4d6a-4e73-b051-cfefed3855f0", "94ada9e1-7548-495c-94c6-d1336da254f6" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 15, 14, 53, 33, 137, DateTimeKind.Local).AddTicks(2976));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a59764ae-d0f1-4288-b37a-1009cced3f26", "AQAAAAEAACcQAAAAELfeSXwCXLJejOMy469EfTYnbHjyjmxzZveyeJbxewBRClfSlzo97IMHKvpIBrKepg==", "db0107eb-27ab-4154-a20f-5208f93898cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1163da51-2369-4b12-aef5-86c360e358de",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34262114-e23a-40f8-9603-af2814000d71", "1730cbe1-13a9-4c95-a7f7-a71e30ddb027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62fb1752-e751-40a5-b3f7-8f23d9be99a9", "f8eb22a5-5527-4f81-87ff-6cb072fae4d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00a871ed-872b-452d-b25c-7e8845db86b2", "b0336d49-4866-4003-9873-98066afdd022" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18f7e522-1ac3-47e9-8d55-7db76a627e6b", "8ceaaed3-ba03-47f6-ad4c-024458e0edfd" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 12, 7, 22, 44, 33, 123, DateTimeKind.Local).AddTicks(5849));
        }
    }
}
