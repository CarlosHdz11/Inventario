using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentasEnLinea.AcessoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarMigracionBodega : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nombre = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "NUMBER(1)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bodegas");
        }
    }
}
