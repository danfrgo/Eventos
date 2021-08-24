using Eventos.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        // criar as tabelas
        public DbSet<Evento> Eventos { get; set; }


    }
}