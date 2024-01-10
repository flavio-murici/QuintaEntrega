using Microsoft.EntityFrameworkCore;
using QuintaEntrega.Models;
using System.Collections.Generic;

namespace QuintaEntrega.Context
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Destino> Destino { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destino>().HasData(
                new Destino { Id = 1, Nome = "Porto de Galinhas", Pais = "Brasil", Estado = "Pernambuco", Cidade = "Ipojuca", Valor = "R$1500,00", Img = "https://www.cvc.com.br/dicas-de-viagem/wp-content/uploads/2023/05/maragogi-porto-de-galinhas-vista-1170x650.jpg" },
                new Destino { Id = 2, Nome = "Balonismo", Pais = "Brasil", Estado = "Bahia", Cidade = "Santo Antônio de Jesus", Valor = "R$2500,00", Img = "https://www.bahianoticias.com.br/_next/image?url=https%3A%2F%2Fwww.bahianoticias.com.br%2Ffotos%2Fhall_travellings%2F228%2FIMAGEM_TRAVELLING_9.jpg%3Fchecksum%3D1674165596&w=1920&q=75" },
                new Destino { Id = 3, Nome = "Arraial do Cabo", Pais = "Brasil", Estado = "Rio de Janeiro", Cidade = "Arraial do Cabo", Valor = "R$5500,00", Img = "https://www.melhoresdestinos.com.br/wp-content/uploads/2020/09/arraial-do-cabo-capa2019-1536x805.jpg" },
                new Destino { Id = 4, Nome = "Natal Luz", Pais = "Brasil", Estado = "Rio Grande do Sul", Cidade = "Gramado", Valor = "R$5000,00", Img = "https://magazine.zarpo.com.br/wp-content/uploads/2019/05/gramado-tudo-sobre-a-cidade-mais-charmosa-do-rio-grande-do-sul-770x500.jpg" },
                new Destino { Id = 5, Nome = "Torre Eiffel", Pais = "França", Estado = "-", Cidade = "Paris", Valor = "R$8500,00", Img = "https://www.cp4.com.br/wp-content/uploads/2019/02/Paris.jpg" },
                new Destino { Id = 6, Nome = "Cancun", Pais = "México", Estado = "Cidade do México", Cidade = "Cancun", Valor = "R$9500,00", Img = "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/05/viagem-para-cancun-1170x780.jpg.optimal.jpg" },
                new Destino { Id = 7, Nome = "Grécia", Pais = "Grécia", Estado = "Grécia", Cidade = "Atenas", Valor = "R$13500,00", Img = "https://www.costacruzeiros.com/content/dam/costa/costa-magazine/articles-magazine/travel/greece-travel/grecia_d.jpg.image.648.487.high.jpg" },
                new Destino { Id = 8, Nome = "Austrália", Pais = "Austrália", Estado = "-", Cidade = "Sidney", Valor = "R$9500,00", Img = "https://www.estudarfora.org.br/wp-content/uploads/2021/01/Australia.jpg.webp" }



                );

        }

    }

}