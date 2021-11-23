using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class CodigoCorEntrada
    {
        [Required(ErrorMessage = "OBRIGATÓRIO")]
        [Range(1, 3000, ErrorMessage = "PARES de 1 à 3.0000")]
        public int ParInicial { get; set; }

        [Required(ErrorMessage = "OBRIGATÓRIO")]
        [Range(1, 3000, ErrorMessage = "PARES de 1 à 3.0000")]
        public int ParDesejado { get; set; }
    }
}
