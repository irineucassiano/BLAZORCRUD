using BlazorCrudFuncionario.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrudFuncionario.Models
{
    public class Funcionario
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage ="O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [EnumDataType(typeof(Cargos), ErrorMessage = "Selecione o cargo do funcionario")]
        public Cargos Cargo { get; set; }
        [Required]
        [EnumDataType(typeof(Setores), ErrorMessage = "Selecione o setor do funcionário")]
        public Setores Setor { get; set; }
        [Required]  
        public string Salario { get; set; }
        [Required]
        public DateOnly Admissao { get; set; }


        public void GenerateNewId()
        {
            Id = Guid.NewGuid();
        }

    }
}
