using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BCIT_ID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Option = table.Column<string>(nullable: true),
                    Set = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BCIT_ID", "City", "Email", "FirstName", "LastName", "MobileNumber", "Option", "Set" },
                values: new object[,]
                {
                    { "a4dac49b-b167-46c3-a751-54877d70d378", "A01222210", "Burnaby", "aa@gmail.com", "Yashi", "Girdhar", "604-111-1234", "AI", "S" },
                    { "9eb10b36-abf6-40bf-9c3a-fb8fe087a271", "A01882220", "Vancouver", "bb@gmail.com", "Frey", "Tolman", "604-000-1234", "Web", "A" },
                    { "ac524377-3e66-432e-903f-260697348e6f", "A01772230", "Surrey", "cc@gmail.com", "John", "Doe", "604-333-1234", "Cloud", "B" },
                    { "f4bfe031-0d78-4fe2-b37a-ef4bf3e59a1f", "A01662240", "Burnaby", "dd@gmail.com", "Yun", "Wong", "604-444-1234", "Web", "A" },
                    { "d990d94e-4ed7-45d9-a340-3e15d8754192", "A01552250", "Vancouver", "ee@gmail.com", "Brian", "White", "604-555-1234", "AI", "S" },
                    { "bff01aeb-16aa-4eb7-b8c3-e079d654228c", "A01442260", "Burnaby", "ff@gmail.com", "Jane", "Kim", "604-666-1234", "Technical Program", "D" },
                    { "be4eabdb-05e7-4764-99e1-9d77e2edd816", "A01332270", "Surrey", "gg@gmail.com", "Kay", "K", "604-777-1234", "AI", "S" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
