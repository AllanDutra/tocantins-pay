namespace TocantinsPay.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IClienteRepository Clientes { get; }
        ICarteiraRepository Carteiras { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
    }
}
