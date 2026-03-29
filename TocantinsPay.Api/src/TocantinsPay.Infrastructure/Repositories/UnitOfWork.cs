using Microsoft.EntityFrameworkCore.Storage;
using TocantinsPay.Core.Interfaces.Repositories;

namespace TocantinsPay.Infrastructure.Repositories
{
    public class UnitOfWork(
        TocantinsPayContext dbContext,
        IClienteRepository clientes,
        ICarteiraRepository carteiras
    ) : IUnitOfWork
    {
        private IDbContextTransaction? _transaction;

        public IClienteRepository Clientes => clientes;

        public ICarteiraRepository Carteiras => carteiras;

        public async Task BeginTransactionAsync()
        {
            _transaction = await dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction == null)
                throw new Exception("Nenhuma transação iniciada");

            try
            {
                await _transaction.CommitAsync();
            }
            catch (Exception)
            {
                await _transaction.RollbackAsync();

                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                dbContext.Dispose();
        }
    }
}
