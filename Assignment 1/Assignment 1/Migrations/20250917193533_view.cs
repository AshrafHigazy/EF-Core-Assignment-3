using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW viewInstractorsAndCourses AS
                SELECT  i.name,  c.Name
                FROM Instructor i
                JOIN Course_Inst ci ON i.ID = ci.Course_ID
                JOIN Courses c ON ci.Course_ID = c.CourseId
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
