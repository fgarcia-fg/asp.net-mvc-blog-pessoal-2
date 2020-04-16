using BlogPessoal.Web.Models;
using System.Data.Entity.ModelConfiguration;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo");

            HasKey(t => t.Id);

            Property(x => x.Titulo).IsRequired().HasMaxLength(300).HasColumnName("titulo");
            Property(x => x.Conteudo).IsOptional().HasColumnName("conteudo");
            Property(x => x.DataPublicacao).IsRequired().HasColumnName("data_publicacao");
            Property(x => x.CategoriaArtigoId).IsRequired().HasColumnName("categoria_artigo_id");
            Property(x => x.AutorId).IsRequired().HasColumnName("autor_id");
            Property(x => x.Removido).HasColumnName("removido");
        }
    }
}