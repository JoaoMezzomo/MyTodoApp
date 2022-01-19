using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Title { get; set; }
        [DisplayName("Concluído")]
        public bool Done { get; set; }
        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Última Atualização")]
        public DateTime LasUpdateDate { get; set; }
        [DisplayName("Usuário")]
        public string User { get; set; }
    }
}
