using System;
using System.ComponentModel.DataAnnotations;

namespace AR_APIRest_.Domain
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo (0) é obrigatório ")]
        [MaxLength(50, ErrorMessage = "O Campo (0) deve ter no máximo (20) Caracteres")]

        public string Nome { get; set }
        public string CPF { get; set }
        public int Idade { get; set }


    }
}
