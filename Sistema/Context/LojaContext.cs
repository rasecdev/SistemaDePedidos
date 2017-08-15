using Sistema.Models;
using System.Data.Entity;

namespace Sistema.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        
    }
}