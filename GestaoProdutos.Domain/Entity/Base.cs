using System.ComponentModel.DataAnnotations;

namespace GestaoProdutos.Dominio.Entity
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}