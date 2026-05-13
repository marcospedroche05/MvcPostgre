using Microsoft.EntityFrameworkCore;
using MvcPostgre.Data;
using MvcPostgre.Models;

namespace MvcPostgre.Repositories
{
    public class RepositoryDepartamentos
    {
        private HospitalContext context;
        public RepositoryDepartamentos(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            return await this.context.Departamentos.ToListAsync();
        }

        public async Task<Departamento> FindDepartamentoAsync(int id)
        {
            return await this.context.Departamentos.FirstOrDefaultAsync(x => x.IdDepartamento == id);
        }

        public async Task CreateDepartamentoAsync(int dept_no, string dnombre, string loc)
        {
            Departamento dept = new Departamento
            {
                IdDepartamento = dept_no,
                Nombre = dnombre,
                Localidad = loc
            };
            await this.context.Departamentos.AddAsync(dept);
            await this.context.SaveChangesAsync();
        }
    }
}
