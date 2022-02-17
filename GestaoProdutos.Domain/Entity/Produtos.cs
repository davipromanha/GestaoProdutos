using GestaoProdutos.Dominio.Objetos;
using System;

namespace GestaoProdutos.Dominio.Entity
{
    public class Produtos : Fornecedores
    {
        public int Id { get; set; }
        public string DescricaoProduto { get; set; }
        public Situacoes situacaoProduto { get; set; }
        public DateTime DataFabricao { get; set; }
        public DateTime DataValidade { get; set; }
    }
}