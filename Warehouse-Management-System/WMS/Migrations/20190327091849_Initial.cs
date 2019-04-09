using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Client_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(maxLength: 20, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 20, nullable: false),
                    Spent_Money = table.Column<decimal>(nullable: false),
                    Is_VIP = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Client_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(nullable: false),
                    Last_Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Years_Of_Service = table.Column<int>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Position = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Item_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name_Of_Item = table.Column<string>(maxLength: 20, nullable: false),
                    Date_Added = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Expiration_Date = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Stored_By = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Item_Id);
                    table.ForeignKey(
                        name: "FK_Items_Employees_Stored_By",
                        column: x => x.Stored_By,
                        principalTable: "Employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_Stored_By",
                table: "Items",
                column: "Stored_By");
            migrationBuilder.CreateTable(
            name: "Employees",
            columns: table => new
            {
                Employee_Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                First_Name = table.Column<string>(nullable: false),
                Last_Name = table.Column<string>(nullable: false),
                Age = table.Column<int>(nullable: false),
                Years_Of_Service = table.Column<int>(nullable: false),
                Salary = table.Column<decimal>(nullable: false),
                Position = table.Column<string>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Employees", x => x.Employee_Id);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
