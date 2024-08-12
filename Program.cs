using Blackjack_Kata;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
        Console.WriteLine("Thanks for playing! Press any key to exit.");
        Console.ReadKey();
    }
}
