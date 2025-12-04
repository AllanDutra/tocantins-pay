namespace TocantinsPay.Core.Entities;

public class Transacao
{
    public Guid Id { get; set; }

    public short Tipo { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor { get; set; }

    public decimal SaldoResultante { get; set; }

    public string? Descricao { get; set; }

    public Guid CarteiraId { get; set; }

    public Guid? CofrinhoId { get; set; }
}
