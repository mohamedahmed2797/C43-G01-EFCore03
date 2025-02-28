using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class CreateStud_CoursesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_Stud_Id",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_courses_Course_Id",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "Stud_Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_Course_Id",
                table: "Stud_Courses",
                newName: "IX_Stud_Courses_Course_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_Id",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.RenameTable(
                name: "Stud_Courses",
                newName: "Stud_Course");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Courses_Course_Id",
                table: "Stud_Course",
                newName: "IX_Stud_Course_Course_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_Stud_Id",
                table: "Stud_Course",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_courses_Course_Id",
                table: "Stud_Course",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
