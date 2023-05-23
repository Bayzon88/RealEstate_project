using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("1ef4c507-437a-49cb-bd6e-7e0b2f48c80e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("7ff64216-4433-47c0-80c6-4cf57da15deb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("a0445060-ade5-4c45-93e5-b4a53785b0e7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("c903e2ee-f6b8-43bf-acbc-d5dce2d05a09"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("26d89cb0-9548-4e70-b7ef-df3793197413"), new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8293), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8295), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("976ae5eb-2166-40aa-82a6-63413e5b0292"), new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8236), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8286), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("acf3f13e-c66c-4da4-9589-d6bc5ef9b0d3"), new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8298), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8300), "Katya Meneses", "katya1234", 123456789L },
                    { new Guid("f545fc5a-c424-43d4-84b5-ae1aa267918a"), new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8304), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8306), "Anton Vinokurov", "anton1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 21, 23, 33, 55, 497, DateTimeKind.Local).AddTicks(8619));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("26d89cb0-9548-4e70-b7ef-df3793197413"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("976ae5eb-2166-40aa-82a6-63413e5b0292"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("acf3f13e-c66c-4da4-9589-d6bc5ef9b0d3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("f545fc5a-c424-43d4-84b5-ae1aa267918a"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("1ef4c507-437a-49cb-bd6e-7e0b2f48c80e"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3572), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3574), "Katya Meneses", "katya1234", 123456789L },
                    { new Guid("7ff64216-4433-47c0-80c6-4cf57da15deb"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3577), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3578), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("a0445060-ade5-4c45-93e5-b4a53785b0e7"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3568), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3570), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("c903e2ee-f6b8-43bf-acbc-d5dce2d05a09"), new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3533), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3565), "Alvaro Beltran", "alvaro1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 20, 19, 37, 40, 297, DateTimeKind.Local).AddTicks(3735));
        }
    }
}
