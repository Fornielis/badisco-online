using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class HomeContato
    {
        [Required(ErrorMessage = "OBRIGATÓRIO")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "OBRIGATÓRIO")]
        public string Email { get; set; }
        [Required(ErrorMessage = "OBRIGATÓRIO")]
        public string Mensagem { get; set; }
    }
}
