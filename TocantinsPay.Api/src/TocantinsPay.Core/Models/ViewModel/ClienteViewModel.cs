namespace TocantinsPay.Core.Models.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Guid id, string nomeCompleto, DateOnly dataNascimento)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
        }

        public Guid Id { get; }
        public string NomeCompleto { get; }
        public DateOnly DataNascimento { get; }

    }
}
