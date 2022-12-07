using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackingNumber",
                table: "Orders");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrackingNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
