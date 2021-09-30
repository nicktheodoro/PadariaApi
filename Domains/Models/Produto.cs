using System.ComponentModel.DataAnnotations;

namespace PadariaApi.Domains.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        
        public Categoria Categoria { get; set; }
    }
}