using Altsystems.ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Altsystems.ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contato { get; set; }

    }
}
