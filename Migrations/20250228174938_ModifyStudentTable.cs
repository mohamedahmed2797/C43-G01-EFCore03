using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class ModifyStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_IdId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_IdId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_IdId",
                table: "Students",
                column: "Dept_IdId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_IdId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_IdId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_IdId",
                table: "Students",
                column: "Dept_IdId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
