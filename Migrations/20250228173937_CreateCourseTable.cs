using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_IdId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_Course_Id",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Top_IdId",
                table: "courses",
                newName: "IX_courses_Top_IdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_courses_CourseId",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Topic_Top_IdId",
                table: "courses",
                column: "Top_IdId",
                principalTable: "Topic",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_courses_Course_Id",
                table: "Stud_Course",
                column: "Course_Id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_courses_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_Topic_Top_IdId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_courses_Course_Id",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_courses_Top_IdId",
                table: "Course",
                newName: "IX_Course_Top_IdId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_IdId",
                table: "Course",
                column: "Top_IdId",
                principalTable: "Topic",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_CourseId",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_Course_Id",
                table: "Stud_Course",
                column: "Course_Id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
