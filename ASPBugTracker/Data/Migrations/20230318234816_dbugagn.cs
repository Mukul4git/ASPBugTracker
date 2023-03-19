using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPBugTracker.Data.Migrations
{
    public partial class dbugagn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bug_Priority_PriorityId1",
                table: "bug");

            migrationBuilder.DropForeignKey(
                name: "FK_bug_Status_StatusId1",
                table: "bug");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId1",
                table: "bug",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId1",
                table: "bug",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Priority_PriorityId1",
                table: "bug",
                column: "PriorityId1",
                principalTable: "Priority",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Status_StatusId1",
                table: "bug",
                column: "StatusId1",
                principalTable: "Status",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bug_Priority_PriorityId1",
                table: "bug");

            migrationBuilder.DropForeignKey(
                name: "FK_bug_Status_StatusId1",
                table: "bug");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId1",
                table: "bug",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId1",
                table: "bug",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Priority_PriorityId1",
                table: "bug",
                column: "PriorityId1",
                principalTable: "Priority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Status_StatusId1",
                table: "bug",
                column: "StatusId1",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
