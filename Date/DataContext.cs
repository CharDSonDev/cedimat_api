using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace cedimat_api.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; } = null!;
        public DbSet<Medico> Medicos { get; set; } = null!;
        public DbSet<Especialidad> Especialidades { get; set; } = null!;
        public DbSet<Cita> Citas { get; set; } = null!;
        public DbSet<Horario> Horarios { get; set; } = null!;
    }
}