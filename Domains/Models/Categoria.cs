using System.Collections.Generic;

namespace PadariaApi.Domains.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}