namespace Task4;

class Program
{
    static void Main()
    {
        Player player1 = new Player();
        Player player2 = new("Rajendra Katuwal", 100, 200);

        Console.WriteLine("===============================================");
        Console.WriteLine("Player 1 Informations");
        Console.WriteLine("===============================================");
        Console.WriteLine($"Player Name = {player1.playerName??"Default Player"}");
        Console.WriteLine($"Level = {player1.level}");
        Console.WriteLine($"Health = {player1.health}");
        Console.WriteLine("===============================================\n\n");

        Console.WriteLine("===============================================");
        Console.WriteLine("Player 2 Informations");
        Console.WriteLine("===============================================");
        Console.WriteLine($"Player Name = {player2.playerName}");
        Console.WriteLine($"Level = {player2.level}");
        Console.WriteLine($"Health = {player2.health}");
        Console.WriteLine("===============================================\n");

    }
}