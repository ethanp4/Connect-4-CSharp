class Program
{
  static void Main()
  {
    string? input;
    int players;

    Console.WriteLine("1 or 2 players?");

    do
    {
      input = Console.ReadLine();
    } while (!int.TryParse(input, out players) || (players != 1 && players != 2));

    Game game = new(players);

    game.Play();

    //6 rows, 7 columns

  }
}
