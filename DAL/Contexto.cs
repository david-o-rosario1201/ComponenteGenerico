using ComponenteGenerico.Models;
using Microsoft.EntityFrameworkCore;

namespace ComponenteGenerico.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Metas> Metas { get; set; }
    public DbSet<Aportes> Aportes { get; set; }
    public DbSet<Prioridades> Prioridades { get; set; }
}