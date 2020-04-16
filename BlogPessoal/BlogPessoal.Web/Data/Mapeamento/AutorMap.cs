using BlogPessoal.Web.Models;
using System.Data.Entity.ModelConfiguration;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("autor");

            HasKey(t => t.Id);

            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Email).IsOptional().HasMaxLength(150).HasColumnName("email");
            Property(x => x.Senha).IsRequired().HasMaxLength(50).HasColumnName("senha");
            Property(x => x.Administrador).IsRequired().HasColumnName("administrador");
            Property(x => x.DataCadastro).IsRequired().HasColumnName("data_cadastro");
        }
    }
}