using TocantinsPay.Core.Entities;
using TocantinsPay.Core.Enums;

namespace TocantinsPay.Core.Models.InputModels
{
    public class ClienteInputModel(
        string nomeCompleto,
        string email,
        string cpf,
        DateOnly dataNascimento,
        string telefone,
        string senha
        )
    {
        public string NomeCompleto { get; } = nomeCompleto;

        public string Email { get; } = email;

        public string Cpf { get; } = cpf;

        public DateOnly DataNascimento { get; } = dataNascimento;

        public string Telefone { get; } = telefone;

        public string Senha { get; } = senha;
    }
}
