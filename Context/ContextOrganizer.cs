using Microsoft.EntityFrameworkCore;
using Modulo_API.Models;

namespace Modulo_API.Context
{
    public class ContextOrganizer : DbContext
    {
        public ContextOrganizer(DbContextOptions<ContextOrganizer> options) : base(options)
        {

        }
        public DbSet<Carro> Carros{ get; set; }        
    }
}