using Microsoft.EntityFrameworkCore;

namespace PRACTICASEJERCICIOS.APPMVCCodeFirst.Models
{
    public class CodeFirstDbContext: DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }


    }
}
