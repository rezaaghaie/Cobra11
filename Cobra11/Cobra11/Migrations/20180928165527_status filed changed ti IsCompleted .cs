using Microsoft.EntityFrameworkCore.Migrations;

namespace Cobra11.Migrations
{
    public partial class statusfiledchangedtiIsCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ToDoItems",
                newName: "IsCompleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "ToDoItems",
                newName: "Status");
        }
    }
}
