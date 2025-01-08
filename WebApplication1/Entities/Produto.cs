using System.Collections.ObjectModel;

namespace BlazorApi.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public int CategriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public Collection<CarrinhoItem> Produtos { get; set; } = new Collection<CarrinhoItem>();

    }
}
