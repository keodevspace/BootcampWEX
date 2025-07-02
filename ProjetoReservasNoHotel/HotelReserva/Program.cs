using HotelReserva.Models;

class Program
{
    static void Main()
    {
        // Criar suíte
        Suite suite = new Suite("Premium", 3, 150.00M);

        // Criar hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("João", "Silva"),
            new Pessoa("Maria", "Souza")
        };

        // Criar reserva
        Reserva reserva = new Reserva(diasReservados: 12);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibir informações
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria():F2}");
    }
}
