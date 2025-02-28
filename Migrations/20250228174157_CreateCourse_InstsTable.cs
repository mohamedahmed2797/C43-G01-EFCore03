using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourse_InstsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructors_InstructorId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_courses_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                newName: "Course_Insts");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Inst_InstructorId",
                table: "Course_Insts",
                newName: "IX_Course_Insts_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Inst_CourseId",
                table: "Course_Insts",
                newName: "IX_Course_Insts_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_courses_CourseId",
                table: "Course_Insts",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_courses_CourseId",
                table: "Course_Insts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.RenameTable(
                name: "Course_Insts",
                newName: "Course_Inst");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Insts_InstructorId",
                table: "Course_Inst",
                newName: "IX_Course_Inst_InstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Insts_CourseId",
                table: "Course_Inst",
                newName: "IX_Course_Inst_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructors_InstructorId",
                table: "Course_Inst",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_courses_CourseId",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
