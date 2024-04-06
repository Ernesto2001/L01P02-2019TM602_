using Microsoft.EntityFrameworkCore;
namespace L01P02_2019TM602_.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<notas> facultades { get; set; }
        public DbSet<notas> materias { get; set; }
        public DbSet<notas> departamentos { get; set; }
        public DbSet<notas> alumnos { get; set; }
    }

    
}

