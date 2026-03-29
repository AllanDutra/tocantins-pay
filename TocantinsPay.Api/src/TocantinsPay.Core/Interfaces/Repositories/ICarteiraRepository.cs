using TocantinsPay.Core.Entities;

namespace TocantinsPay.Core.Interfaces.Repositories
{
    public interface ICarteiraRepository
    {
        Task<Guid> CadastrarAsync(Carteira carteira);
    }
}
