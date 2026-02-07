using TocantinsPay.Core.Interfaces.Applications;
using TocantinsPay.Core.Interfaces.Repositories;
using TocantinsPay.Core.Mappers;
using TocantinsPay.Core.Models.ViewModel;

namespace TocantinsPay.Application.Applications
{
    public class BuscarClientesApplication(IClienteRepository clienteRepository) : IBuscarClientesApplication
    {
        public async Task<IEnumerable<ClienteViewModel>> BuscarAsync()
        {
            var clientes = await clienteRepository.BuscarAsync();

            return clientes.Select(c => c.ToViewModel());
        }
    }
}
