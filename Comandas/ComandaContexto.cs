using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    //classe que representa o banco de dados
    public class BancoDeDados : DbContext
    {
        //propriedade que representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }

        //metodos que configura informando para o EF que o banco será SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }
}

