using BlazorCrudFuncionario.Models;

namespace BlazorCrudFuncionario.Services
{
    public interface IFuncionarioServices
    {
        Task AddFuncionario(Funcionario funcionario);
        Task UpdateFuncionario(Funcionario funcionario);
        Task DeleteFuncionario(Funcionario funcionario);
        Task<Funcionario> GetById(Guid id);
        Task<List<Funcionario>> FindAll();

    }
}
