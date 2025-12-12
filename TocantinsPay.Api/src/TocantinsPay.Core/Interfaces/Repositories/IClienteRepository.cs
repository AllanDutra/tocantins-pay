using TocantinsPay.Core.Entities;

namespace TocantinsPay.Core.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<Guid> CadastrarAsync(Cliente cliente);
    }
}
