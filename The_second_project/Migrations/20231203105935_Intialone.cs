using Microsoft.EntityFrameworkCore.Migrations;

namespace The_second_project.Migrations
{
    public partial class Intialone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_courseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_departmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_courseId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_departmentId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Instructors");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_dept_id",
                table: "Instructors",
                column: "dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors",
                column: "crs_id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors",
                column: "dept_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_crs_id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_dept_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_crs_id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_dept_id",
                table: "Instructors");

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_courseId",
                table: "Instructors",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_departmentId",
                table: "Instructors",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_courseId",
                table: "Instructors",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_departmentId",
                table: "Instructors",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
