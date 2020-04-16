using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class Artigo
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int CategoriaArtigoId { get; set; }

        public int AutorId { get; set; }

        public bool Removido { get; set; }
    }
}