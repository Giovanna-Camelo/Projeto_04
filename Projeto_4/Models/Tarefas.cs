using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projeto_4.Models
{
    public class Tarefas
    {
        public int TarefaId { get; set; }
        [Display(Name = "Nome da Tarefa")]
        public string? TarefaName { get; set; }
        [Display(Name = "Descrição da Tarefa")]
        public string? TarefaDescription { get; set; }
        public string? Data { get; set; }
        public string? Status { get; set; }
    }
}
