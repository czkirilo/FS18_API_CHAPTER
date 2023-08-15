using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        { }
        // vamos utilizar esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada computador vai ter seu proprio caminho e cada provedor sua sintaxe
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate=True");
                //optionsBuilder.UseSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS; initial catalog = Chapter; user id = banana; passwaord = nanica");
            }
        }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
