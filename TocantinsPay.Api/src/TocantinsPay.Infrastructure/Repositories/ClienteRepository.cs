using Microsoft.EntityFrameworkCore;
using TocantinsPay.Core.Entities;
using TocantinsPay.Core.Interfaces.Repositories;

namespace TocantinsPay.Infrastructure.Repositories
{
    public class ClienteRepository(TocantinsPayContext dbContext) : IClienteRepository
    {
        private readonly TocantinsPayContext _dbContext = dbContext;

        public async Task<Guid> CadastrarAsync(Cliente cliente)
        {
            var entidade = await _dbContext.Clientes.AddAsync(cliente);

            await _dbContext.SaveChangesAsync();

            return entidade.Entity.Id;
        }

        public async Task<IEnumerable<Cliente>> BuscarAsync()
        {
            var clientes = await _dbContext.Clientes.ToListAsync();

            return clientes;
        }

        public async Task<Cliente?> BuscarPorIdAsync(Guid id)
        {
            var cliente = await _dbContext.Clientes.FirstOrDefaultAsync(c => c.Id == id);

            return cliente;
        }
    }
}
