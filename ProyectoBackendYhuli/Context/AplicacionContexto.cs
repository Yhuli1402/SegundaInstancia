using Microsoft.EntityFrameworkCore;
using ProyectoBackendYhuli.Models;

namespace ProyectoBackendYhuli.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Albaniles> Albaniles { get; set; }
        public DbSet<Cuadrillas> Cuadrillas { get; set; }

    }
}