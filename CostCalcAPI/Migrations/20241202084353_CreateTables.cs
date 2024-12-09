using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostCalcAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadCosts_Projects_ProjectId",
                table: "OverheadCosts");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "OverheadCosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadCosts_Projects_ProjectId",
                table: "OverheadCosts",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OverheadCosts_Projects_ProjectId",
                table: "OverheadCosts");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "OverheadCosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OverheadCosts_Projects_ProjectId",
                table: "OverheadCosts",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
