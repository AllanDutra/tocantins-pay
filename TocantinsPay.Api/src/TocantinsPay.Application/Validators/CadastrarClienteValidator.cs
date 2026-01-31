using FluentValidation;
using TocantinsPay.Core.Models.InputModels;
using TocantinsPay.Shared.Utils;

namespace TocantinsPay.Application.Validators
{
    public class CadastrarClienteValidator : AbstractValidator<ClienteInputModel>
    {
        public CadastrarClienteValidator()
        {
            RuleFor(c => c.NomeCompleto)
                .NotEmpty()
                .WithMessage("O nome completo do cliente deve ser informado.");

            RuleFor(c => c.Email)
                .NotEmpty()
                .WithMessage("O e-mail do cliente deve ser informado.")
                .EmailAddress()
                .WithMessage("O e-mail informado é inválido.");

            RuleFor(c => c.Cpf)
                .NotEmpty()
                .WithMessage("O cpf do cliente deve ser informado.")
                .Must(Validacoes.IsCpf)
                .WithMessage("O cpf informado é inválido.");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                .WithMessage("O telefone do cliente deve ser informado.")
                .MaximumLength(200)
                .WithMessage("O telefone não deve ultrapassar 200 caracteres.");

            RuleFor(c => c.Senha)
                .NotEmpty()
                .WithMessage("A senha do cliente deve ser informada.");
        }
    }
}
