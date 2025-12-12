using TocantinsPay.Core.Enums;

namespace TocantinsPay.Core.Entities;

public class Cliente
{
    public Cliente(string nomeCompleto, string email, string cpf, DateOnly dataNascimento, string telefone, string senha)
    {
        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        Situacao = ESituacaoCliente.Ativo;
        Email = email;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        Senha = senha;
    }

    public Guid Id { get; }

    public string NomeCompleto { get; }

    public ESituacaoCliente Situacao { get; }

    public string Email { get; }

    public string Cpf { get; }

    public DateOnly DataNascimento { get; }

    public string Telefone { get; }

    public string Senha { get; }
}
