using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("0f706a62-35a8-4783-9225-83ec40e22ed1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("56b5e1f5-ee2a-401b-8eaa-7de7508f8a3b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("9fd82805-f78e-4ebe-95ab-150954881fe2"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("d2585562-ba63-41ae-9dc5-fef70a196958"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("8538a40e-c8c7-4504-aa64-84c90b885617"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4124), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4125), "Katya Meneses", "katya1234", 123456789L },
                    { new Guid("971e239d-e109-4c0e-88a0-0b5db88da809"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4128), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4130), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("c3b8471d-a8b1-45c7-bd21-e3b13aca2125"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4079), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4116), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("ecfec008-80f0-4025-8d48-90f90b682655"), new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4119), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 48, 50, 409, DateTimeKind.Local).AddTicks(4121), "Tuyi Chen", "tuyi1234", 123456789L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("8538a40e-c8c7-4504-aa64-84c90b885617"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("971e239d-e109-4c0e-88a0-0b5db88da809"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("c3b8471d-a8b1-45c7-bd21-e3b13aca2125"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("ecfec008-80f0-4025-8d48-90f90b682655"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("0f706a62-35a8-4783-9225-83ec40e22ed1"), new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2535), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2536), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("56b5e1f5-ee2a-401b-8eaa-7de7508f8a3b"), new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2543), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2545), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("9fd82805-f78e-4ebe-95ab-150954881fe2"), new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2490), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2531), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("d2585562-ba63-41ae-9dc5-fef70a196958"), new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2539), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 20, 16, 46, 47, 986, DateTimeKind.Local).AddTicks(2541), "Katya Meneses", "katya1234", 123456789L }
                });
        }
    }
}
