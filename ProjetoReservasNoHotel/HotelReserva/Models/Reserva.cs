namespace HotelReserva.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
            throw new InvalidOperationException("A suíte deve ser cadastrada antes de adicionar hóspedes.");

        if (hospedes.Count > Suite.Capacidade)
            throw new ArgumentException("Capacidade da suíte é inferior ao número de hóspedes.");

        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados > 10)
        {
            valor *= 0.9M; // Desconto de 10%
        }

        return valor;
    }
}
