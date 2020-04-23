using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Web.Models
{
    public class CategoriaDeArtigo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [Display(Name = "Nome da categoria")]
        public string Nome { get; set; }

        [Display(Name = "Descrição da categoria")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 3)]
        public string Descricao { get; set; }
    }
}