using GestaoProdutos.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProdutos.Infrastructure.Data.Mapping
{
    public class ProdutosMap : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder) 
        {
            builder.ToTable("Produtos");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.DescricaoProduto)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(u => u.DataFabricao)
                    .IsRequired();
            builder.Property(u => u.DataValidade)
                    .IsRequired();
            builder.Property(u => u.situacaoProduto)
                    .IsRequired()
                    .HasMaxLength(8);
            builder.Property(u => u.DescricaoFornecedor)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(u => u.CnpjFornecedor)
                    .IsRequired()
                    .HasMaxLength(20);
        }
    }
}
