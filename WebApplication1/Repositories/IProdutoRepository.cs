using BlazorApi.Entities;

namespace BlazorShop.Api.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItens(int id);
        Task<IEnumerable<Produto>> GetItensPorCategoria(int id);


    }
}
