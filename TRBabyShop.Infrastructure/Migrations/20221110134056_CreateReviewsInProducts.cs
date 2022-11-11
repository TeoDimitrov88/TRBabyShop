using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRBabyShop.Infrastructure.Migrations
{
    public partial class CreateReviewsInProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedOn", "ProductId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(48), 1, "Amazing item!", "04ba4719-a5ce-478d-b36d-169ffe19e118" },
                    { 2, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(86), 3, "Very usefull!!Thank you", "04ba4719-a5ce-478d-b36d-169ffe19e118" },
                    { 3, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(89), 3, "It`s perfect for our baby!Thank you", "c225f1de-8898-473c-8b8d-484a5034beea" },
                    { 4, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(92), 8, "Low quality ,im very upset :(", "04ba4719-a5ce-478d-b36d-169ffe19e118" },
                    { 5, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(95), 11, "Excellent :)", "04ba4719-a5ce-478d-b36d-169ffe19e118" },
                    { 6, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(99), 11, "Excellent ,Thank you:)", "cd0f2b40-9353-405c-ae22-c1097419f287" },
                    { 7, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(102), 12, "It`s really expensive for its quality ", "cd0f2b40-9353-405c-ae22-c1097419f287" },
                    { 8, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(104), 4, "Low quality ,not impressed :(", "cd0f2b40-9353-405c-ae22-c1097419f287" },
                    { 9, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(107), 7, "Low quality ,not impressed :(", "cd0f2b40-9353-405c-ae22-c1097419f287" },
                    { 10, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(111), 9, "Low quality ,not impressed :(", "04fa2e1b-1e98-42fa-b709-f364b63cfa91" },
                    { 11, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(113), 3, "Low quality ,not impressed :(", "04fa2e1b-1e98-42fa-b709-f364b63cfa91" },
                    { 12, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(224), 4, "Very good ,thanks", "727a36c2-e76e-4764-a9f6-9402f63c7872" },
                    { 13, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(227), 5, "Very good ,thanks", "727a36c2-e76e-4764-a9f6-9402f63c7872" },
                    { 14, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(230), 8, "Very good ,thanks", "727a36c2-e76e-4764-a9f6-9402f63c7872" },
                    { 15, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(232), 9, "Not recommend :(", "727a36c2-e76e-4764-a9f6-9402f63c7872" },
                    { 16, new DateTime(2022, 11, 10, 15, 40, 56, 220, DateTimeKind.Local).AddTicks(235), 10, "Not recommend :(", "727a36c2-e76e-4764-a9f6-9402f63c7872" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ba4719-a5ce-478d-b36d-169ffe19e118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a60c22d0-9229-4cf9-86c8-67c30cf0745a", "AQAAAAEAACcQAAAAEJrCIF8gIMLYFDlC5lk+vcjtCiUQ0GoJwjVdB+ds2J0DtlPE4hySWQXVXR090686pw==", "ec5027d9-b450-40c3-aba7-2dfabf5293fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c225f1de-8898-473c-8b8d-484a5034beea",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4be30fe4-fcbb-4300-9f49-402dabfbc6b5", "0b5990cd-bbee-4aa2-a0c1-f5a952f05aed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd0f2b40-9353-405c-ae22-c1097419f287",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c87b1bca-22a6-475f-b33b-93d500303490", "b82716e2-8f61-4e42-89e4-4077463322c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5342be8-a61e-47a8-9712-2b0f18ee134d", "dbccd70b-81a5-4368-bd1b-c966a59ea041" });
        }
    }
}
