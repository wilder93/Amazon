using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class UpdateCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "E35EC026-955A-462B-6E8E-08D6DBEB8B2A",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "12CCD978-3A87-4C4F-6E8F-08D6DBEB8B2A",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "87B89DD7-0799-4B0B-6E90-08D6DBEB8B2A",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "F83BA414-6325-4D63-6E91-08D6DBEB8B2A",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "C5D096F3-79ED-4803-6E92-08D6DBEB8B2A",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "72618EF5-3381-4BE3-6E93-08D6DBEB8B2A",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "6657F947-CDD9-43A2-6E94-08D6DBEB8B2A",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "D11782D7-CEE9-4AA1-6E95-08D6DBEB8B2A",
            column: "Category",
            value: "Engineering"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "3B833CE3-1758-4FBC-6E96-08D6DBEB8B2A",
            column: "Category",
            value: "Engineering"
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "E35EC026-955A-462B-6E8E-08D6DBEB8B2A",
           column: "Category",
           value: null
           );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "12CCD978-3A87-4C4F-6E8F-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "87B89DD7-0799-4B0B-6E90-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "F83BA414-6325-4D63-6E91-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "C5D096F3-79ED-4803-6E92-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "72618EF5-3381-4BE3-6E93-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "6657F947-CDD9-43A2-6E94-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "D11782D7-CEE9-4AA1-6E95-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "3B833CE3-1758-4FBC-6E96-08D6DBEB8B2A",
            column: "Category",
            value: null
            );
        }
    }
}
