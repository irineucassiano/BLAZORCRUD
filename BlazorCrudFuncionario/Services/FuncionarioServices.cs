using BlazorCrudFuncionario.Data;
using BlazorCrudFuncionario.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudFuncionario.Services
{
    public class FuncionarioServices : IFuncionarioServices
    {
        private readonly AppDbContext appDbContext;

        public FuncionarioServices(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task AddFuncionario(Funcionario funcionario)
        {
            await appDbContext.AddAsync(funcionario);
            await appDbContext.SaveChangesAsync();
        }

        public async Task UpdateFuncionario(Funcionario funcionario)
        {
            appDbContext.Update(funcionario);
            await appDbContext.SaveChangesAsync();
        }

        public async Task DeleteFuncionario(Funcionario funcionario)
        {
            appDbContext.Remove(funcionario);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<Funcionario> GetById(Guid id)
        {
            var funcionario = await appDbContext.Funcionarios.FirstOrDefaultAsync(c => c.Id == id);
            return funcionario;
        }

        public async Task<List<Funcionario>> FindAll()
        {
            var funcionario = await appDbContext.Funcionarios.ToListAsync();
            return funcionario;
        }
    }
}
