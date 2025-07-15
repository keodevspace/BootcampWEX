using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("111111111", "Nokia C20", "00000000001", 64);
        Smartphone iphone = new Iphone("222222222", "iPhone 13", "00000000002", 128);

        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}
