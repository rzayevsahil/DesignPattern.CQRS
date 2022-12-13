using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.CQRS.PresentationLayer.Migrations
{
    public partial class mig_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductKdv = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStock = table.Column<int>(type: "int", nullable: false),
                    ProductMinStock = table.Column<int>(type: "int", nullable: false),
                    ProductMaxStock = table.Column<int>(type: "int", nullable: false),
                    ProductSizeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductSizeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStorage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
