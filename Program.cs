class Program
{
  static void Main()
  {
    string? input;
    int players;

    Console.WriteLine("1 or 2 players?");

    //collect input
    input = Console.ReadLine();

    while (!int.TryParse(input, out players) || (players != 1 && players != 2))
    {
      // Console.Clear();
      Console.WriteLine("Enter 1 or 2");
      input = Console.ReadLine();
    }

    // Console.Clear();
    PrintStringCharByChar("Connect 4");
    // Thread.Sleep(1500);

    // Console.Clear();
    PrintStringCharByChar(String.Format("Starting with {0} {1}", players, players == 1 ? "player" : "players"));
    // Thread.Sleep(1500);

    Game game = new(players);

    game.Play();

    //6 rows, 7 columns
  }

  public static void PrintStringCharByChar(string str)
  {
    foreach (char c in str)
    {
      Console.Write(c);
      // Thread.Sleep(40);
    }
  }
}
