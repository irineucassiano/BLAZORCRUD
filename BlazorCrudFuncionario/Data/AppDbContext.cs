using BlazorCrudFuncionario.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudFuncionario.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
