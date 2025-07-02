namespace HotelReserva.Models;

public class Suite
{
    public string TipoSuite { get; set; } = string.Empty;
    public int Capacidade { get; set; } = 0; 
    public decimal ValorDiaria { get; set; } = 0;

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}
