using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPBugTracker.Data.Migrations
{
    public partial class trying : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bug_Priority_PriorityId1",
                table: "bug");

            migrationBuilder.DropForeignKey(
                name: "FK_bug_Status_StatusId1",
                table: "bug");

            migrationBuilder.DropIndex(
                name: "IX_bug_PriorityId1",
                table: "bug");

            migrationBuilder.DropIndex(
                name: "IX_bug_StatusId1",
                table: "bug");

            migrationBuilder.DropColumn(
                name: "PriorityId1",
                table: "bug");

            migrationBuilder.DropColumn(
                name: "StatusId1",
                table: "bug");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "bug",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "bug",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_bug_PriorityId",
                table: "bug",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_bug_StatusId",
                table: "bug",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Priority_PriorityId",
                table: "bug",
                column: "PriorityId",
                principalTable: "Priority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bug_Status_StatusId",
                table: "bug",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bug_Priority_PriorityId",
                table: "bug");

            migrationBuilder.DropForeignKey(
                name: "FK_bug_Status_StatusId",
                table: "bug");

            migrationBuilder.DropIndex(
                name: "IX_bug_PriorityId",
                table: "bug");

            migrationBuilder.DropIndex(
                name: "IX_bug_StatusId",
                table: "bug");

            migrationBuilder.AlterColumn<string>(
                name: "StatusId",
                table: "bug",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PriorityId",
                table: "bug",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PriorityId1",
                table: "bug",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId1",
                table: "bug",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bug_PriorityId1",
                table: "bug",
                column: "PriorityId1");

            migrationBuilder.CreateIndex(
                name: "IX_bug_StatusId1",
                table: "bug",
                column: "StatusId1");

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
    }
}
