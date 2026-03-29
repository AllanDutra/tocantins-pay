using TocantinsPay.Core.Entities;
using TocantinsPay.Core.Interfaces.Repositories;

namespace TocantinsPay.Infrastructure.Repositories
{
    public class CarteiraRepository(TocantinsPayContext dbContext) : ICarteiraRepository
    {
        public async Task<Guid> CadastrarAsync(Carteira carteira)
        {
            var entidade = await dbContext.Carteiras.AddAsync(carteira);

            await dbContext.SaveChangesAsync();

            return entidade.Entity.Id;
        }
    }
}
