using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    public partial class departmentupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RowVersion",
                table: "Department",
                type: "tinyint",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldRowVersion: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RowVersion",
                table: "Department",
                type: "tinyint",
                rowVersion: true,
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldRowVersion: true,
                oldNullable: true);
        }
    }
}
