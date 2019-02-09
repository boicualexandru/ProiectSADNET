using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FixedModelsNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Seria 1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Seria 1 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Seria 1 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Seria 2");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Seria 2 Active Tourer");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 364,
                column: "Name",
                value: "Seria 2 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 365,
                column: "Name",
                value: "Seria 2 Gran Tourer");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Seria 3");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "Seria 3 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Seria 3 Compact");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Seria 3 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Seria 3 GT");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Seria 3 Touring");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Seria 4");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Seria 4 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "Seria 4 Gran Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Seria 5");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "Seria 5 GT");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Seria 5 Touring");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Seria 6");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Seria 6 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Seria 6 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Seria 6 Gran Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 382,
                column: "Name",
                value: "Seria 7");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 383,
                column: "Name",
                value: "Seria 8 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "Transporter T4");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "Transporter T4 Caravelle");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "Transporter T4 Multivan");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "Transporter T5");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "Transporter T5 Caravelle");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "Transporter T5 Multivan");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "Transporter T5 Shuttle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Rad 1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Rad 1 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Rad 1 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Rad 2");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Rad 2 Active Tourer");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 364,
                column: "Name",
                value: "Rad 2 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 365,
                column: "Name",
                value: "Rad 2 Gran Tourer");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Rad 3");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "Rad 3 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Rad 3 Compact");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Rad 3 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Rad 3 GT");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Rad 3 Touring");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Rad 4");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Rad 4 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "Rad 4 Gran Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Rad 5");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "Rad 5 GT");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Rad 5 Touring");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Rad 6");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Rad 6 Cabrio");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Rad 6 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Rad 6 Gran Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 382,
                column: "Name",
                value: "Rad 7");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 383,
                column: "Name",
                value: "Rad 8 Coupé");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "T4");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "T4 Caravelle");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "T4 Multivan");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "T5");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "T5 Caravelle");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "T5 Multivan");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Models",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "T5 Transporter Shuttle");
        }
    }
}
