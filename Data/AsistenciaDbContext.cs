using Matriculas.Models;
using Microsoft.EntityFrameworkCore;

namespace Matriculas.Data
{
    public class AsistenciaDbContext:DbContext
    {
        public AsistenciaDbContext(DbContextOptions<AsistenciaDbContext>options):base(options) {


        }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Asistencia> asistencias { get; set; }
       
    }
}
