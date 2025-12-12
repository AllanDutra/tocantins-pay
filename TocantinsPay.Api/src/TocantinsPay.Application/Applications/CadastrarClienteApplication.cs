using TocantinsPay.Core.Entities;
using TocantinsPay.Core.Interfaces.Applications;
using TocantinsPay.Core.Interfaces.Repositories;
using TocantinsPay.Core.Models.InputModels;

namespace TocantinsPay.Application.Applications
{
    public class CadastrarClienteApplication(IClienteRepository clienteRepository) : ICadastrarClienteApplication
    {
        private readonly IClienteRepository _clienteRepository = clienteRepository;

        public async Task<Guid> CadastrarAsync(ClienteInputModel inputModel)
        {
            var cliente = new Cliente(
                inputModel.NomeCompleto,
                inputModel.Email,
                inputModel.Cpf,
                inputModel.DataNascimento,
                inputModel.Telefone,
                inputModel.Senha
            );

            return await _clienteRepository.CadastrarAsync(cliente);
        }
    }
}
