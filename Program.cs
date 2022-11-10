using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia("71931654531", "Nokia 6.1", "356926096671751", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Worms Armageddon");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone IPhone:");
        Iphone iphone = new Iphone("95923925731", "APPLE iPhone 12 Pro Max", "356728118357207", 512);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Flappy Bird");
    }
}