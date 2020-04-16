using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public bool Administrador { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }
    }
}