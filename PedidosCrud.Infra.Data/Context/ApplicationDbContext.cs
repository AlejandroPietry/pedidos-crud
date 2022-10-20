using Microsoft.EntityFrameworkCore;
using PedidosCrud.Infra.Domain.Models;

namespace PedidosCrud.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
