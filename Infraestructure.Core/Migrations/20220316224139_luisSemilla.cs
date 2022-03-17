using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Core.Migrations
{
    public partial class luisSemilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "TypeStateEntity",
                schema: "Master");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Master");

            migrationBuilder.CreateTable(
                name: "TypeStateEntity",
                schema: "Master",
                columns: table => new
                {
                    IdTypeState = table.Column<int>(type: "int", nullable: false),
                    TypeState = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeStateEntity", x => x.IdTypeState);
                });

            migrationBuilder.CreateTable(
                name: "State",
                schema: "Master",
                columns: table => new
                {
                    IdState = table.Column<int>(type: "int", nullable: false),
                    IdTypeState = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.IdState);
                    table.ForeignKey(
                        name: "FK_State_TypeStateEntity_IdTypeState",
                        column: x => x.IdTypeState,
                        principalSchema: "Master",
                        principalTable: "TypeStateEntity",
                        principalColumn: "IdTypeState",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_State_IdTypeState",
                schema: "Master",
                table: "State",
                column: "IdTypeState");
        }
    }
}
