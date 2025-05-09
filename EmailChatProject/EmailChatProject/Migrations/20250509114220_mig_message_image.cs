using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailChatProject.Migrations
{
    /// <inheritdoc />
    public partial class mig_message_image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SenderImage",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenderImage",
                table: "Messages");
        }
    }
}
