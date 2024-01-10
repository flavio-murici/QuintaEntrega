using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuintaEntrega.Migrations
{
    /// <inheritdoc />
    public partial class ultimamigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destino", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destino",
                columns: new[] { "Id", "Cidade", "Estado", "Img", "Nome", "Pais", "Valor" },
                values: new object[,]
                {
                    { 2, "Ipojuca", "Pernambuco", "https://www.cvc.com.br/dicas-de-viagem/wp-content/uploads/2023/05/maragogi-porto-de-galinhas-vista-1170x650.jpg", "Porto de Galinhas", "Brasil", "R$1500,00" },
                    { 3, "Santo Antônio de Jesus", "Bahia", "https://www.bahianoticias.com.br/_next/image?url=https%3A%2F%2Fwww.bahianoticias.com.br%2Ffotos%2Fhall_travellings%2F228%2FIMAGEM_TRAVELLING_9.jpg%3Fchecksum%3D1674165596&w=1920&q=75", "Balonismo", "Brasil", "R$2500,00" },
                    { 4, "Arraial do Cabo", "Rio de Janeiro", "https://www.melhoresdestinos.com.br/wp-content/uploads/2020/09/arraial-do-cabo-capa2019-1536x805.jpg", "Arraial do Cabo", "Brasil", "R$5500,00" },
                    { 5, "Gramado", "Rio Grande do Sul", "https://magazine.zarpo.com.br/wp-content/uploads/2019/05/gramado-tudo-sobre-a-cidade-mais-charmosa-do-rio-grande-do-sul-770x500.jpg", "Natal Luz", "Brasil", "R$5000,00" },
                    { 7, "Paris", "-", "https://www.cp4.com.br/wp-content/uploads/2019/02/Paris.jpg", "Torre Eiffel", "França", "R$8500,00" },
                    { 8, "Cancun", "Cidade do México", "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/05/viagem-para-cancun-1170x780.jpg.optimal.jpg", "Cancun", "México", "R$9500,00" },
                    { 9, "Atenas", "Grécia", "https://www.costacruzeiros.com/content/dam/costa/costa-magazine/articles-magazine/travel/greece-travel/grecia_d.jpg.image.648.487.high.jpg", "Grécia", "Grécia", "R$13500,00" },
                    { 10, "Sidney", "-", "https://www.estudarfora.org.br/wp-content/uploads/2021/01/Australia.jpg.webp", "Austrália", "Austrália", "R$9500,00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destino");
        }
    }
}
