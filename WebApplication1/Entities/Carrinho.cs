using System.Collections.ObjectModel;

namespace BlazorApi.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        public Collection<CarrinhoItem> Produtos { get; set; } = new Collection<CarrinhoItem>();

    }
}
