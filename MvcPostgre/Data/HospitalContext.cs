using Microsoft.EntityFrameworkCore;
using MvcPostgre.Models;

namespace MvcPostgre.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
