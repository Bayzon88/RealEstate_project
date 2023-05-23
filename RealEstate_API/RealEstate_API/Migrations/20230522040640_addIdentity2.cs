using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate_API.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AcctId", "CreationTime", "Email", "Gender", "LastLoginTime", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("405a3a92-6d4c-4a5b-842f-349e67dba7a7"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5569), "antonvinokurov101@gmail.com", "Male", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5571), "Anton Vinokurov", "anton1234", 123456789L },
                    { new Guid("72b63d40-b7b1-4679-8950-ffc6f3981bac"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5560), "tuyichen90@gmail.com", "Female", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5562), "Tuyi Chen", "tuyi1234", 123456789L },
                    { new Guid("839dcf85-5dc8-4607-9842-441724357995"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5524), "beltranalvaro08@gmail.com", "Male", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5557), "Alvaro Beltran", "alvaro1234", 123456789L },
                    { new Guid("d7772b51-0595-4fe4-8584-4577d269a032"), new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5565), "katya.menesesr@gmail.com", "Female", new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5566), "Katya Meneses", "katya1234", 123456789L }
                });

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 1,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 2,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 3,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 4,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 5,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 6,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 7,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 8,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "ListingId",
                keyValue: 9,
                column: "ListingTime",
                value: new DateTime(2023, 5, 22, 0, 6, 39, 846, DateTimeKind.Local).AddTicks(5746));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("405a3a92-6d4c-4a5b-842f-349e67dba7a7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("72b63d40-b7b1-4679-8950-ffc6f3981bac"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("839dcf85-5dc8-4607-9842-441724357995"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AcctId",
                keyValue: new Guid("d7772b51-0595-4fe4-8584-4577d269a032"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

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
    }
}
