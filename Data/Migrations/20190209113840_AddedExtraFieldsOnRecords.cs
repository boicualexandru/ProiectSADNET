using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedExtraFieldsOnRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Models_ModelId",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                schema: "dbo",
                table: "Records");

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                schema: "dbo",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GearBox",
                schema: "dbo",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Fuel",
                schema: "dbo",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EngineSize",
                schema: "dbo",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmissionStandard",
                schema: "dbo",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Body",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryOfOrigin",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoorsNo",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Power",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Registered",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seller",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VIN",
                schema: "dbo",
                table: "Records",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Models_ModelId",
                schema: "dbo",
                table: "Records",
                column: "ModelId",
                principalSchema: "dbo",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Models_ModelId",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Body",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Color",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Condition",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CountryOfOrigin",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "DoorsNo",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Power",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Registered",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Seller",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Transmission",
                schema: "dbo",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "VIN",
                schema: "dbo",
                table: "Records");

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                schema: "dbo",
                table: "Records",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GearBox",
                schema: "dbo",
                table: "Records",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Fuel",
                schema: "dbo",
                table: "Records",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EngineSize",
                schema: "dbo",
                table: "Records",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmissionStandard",
                schema: "dbo",
                table: "Records",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                schema: "dbo",
                table: "Records",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Models_ModelId",
                schema: "dbo",
                table: "Records",
                column: "ModelId",
                principalSchema: "dbo",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
