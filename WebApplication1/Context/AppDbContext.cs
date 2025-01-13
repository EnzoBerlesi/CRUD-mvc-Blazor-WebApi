using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using BlazorApi.Entities;

namespace BlazorShop.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Carrinho>? Carrinhos { get; set; }
        public DbSet<CarrinhoItem>? CarrinhosItens { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 1,
                Nome = "Beleza",
                IconCSS = "fas fa-spa"
            });

            modelBuilder.Entity<Produto>().HasData(
            new Produto
            {
                Id = 1,
                Nome = "Glossier - Beleza Kit",
                Descricao = "Um kit de beleza do bao",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Quantidade = 100,
                CategriaId = 1
            },

            new Produto
            {
                Id = 2,
                Nome = "Fenty Beauty - Maquiagem Essentials",
                Descricao = "Kit completo com os melhores produtos da Fenty Beauty.",
                ImagemUrl = "/Imagens/Beleza/Beleza2.png",
                Preco = 150,
                Quantidade = 80,
                CategriaId = 1
            },
            new Produto
            {
                Id = 3,
                Nome = "Kiehl's - Skincare Basics",
                Descricao = "Pacote essencial para cuidados com a pele.",
                ImagemUrl = "/Imagens/Beleza/Beleza3.png",
                Preco = 200,
                Quantidade = 60,
                CategriaId = 1
            },
            new Produto
            {
                Id = 4,
                Nome = "Urban Decay - Naked Palette",
                Descricao = "Paleta de sombras versátil e elegante.",
                ImagemUrl = "/Imagens/Beleza/Beleza4.png",
                Preco = 120,
                Quantidade = 50,
                CategriaId = 1
            },
            new Produto
            {
                Id = 5,
                Nome = "Dior - Perfume Miss Dior",
                Descricao = "Perfume clássico e sofisticado para ocasiões especiais.",
                ImagemUrl = "/Imagens/Beleza/Beleza5.png",
                Preco = 250,
                Quantidade = 40,
                CategriaId = 2
            },
            new Produto
            {
                Id = 6,
                Nome = "L'Oréal - Cuidado com os Cabelos",
                Descricao = "Kit com shampoo, condicionador e máscara hidratante.",
                ImagemUrl = "/Imagens/Beleza/Beleza6.png",
                Preco = 90,
                Quantidade = 70,
                CategriaId = 2
            }
            );

            modelBuilder.Entity<Usuario>().HasData( //sao os usuarios
            new Usuario
            {
                Id = 1,
                NomeUsuario = "Ze do Repolho"
            },


            new Usuario
            {
                Id = 2,
                NomeUsuario = "Ze do Alface"
            }

            );

            modelBuilder.Entity<Carrinho>().HasData( //é um carrinho de compras para usuarios
                new Carrinho
                {
                    Id = 1,
                    UsuarioId = 1
                },

                new Carrinho
                {
                    Id = 2,
                    UsuarioId = 2
                }

                );

        }
    }
}