using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 5)]
        public string Senha { get; set; }

        [Required]
        public bool Administrador { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }
    }
}