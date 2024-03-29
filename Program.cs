class Program
{
  static void Main()
  {
    Grid grid = new Grid();
    Player player1 = new Player(grid, 1);
    Player player2 = new Player(grid, 2);


    grid.PrintGrid();


    int playCount = 0;


    Player currentPlayer = player1;
    int column;
    while (true)
    {
      Console.WriteLine("Enter a column for {0}", currentPlayer);
      column = int.Parse(Console.ReadLine());

      if (grid.IsColumnFull(column))
      {
        grid.PrintGrid(true);
      }
      else
      {
        currentPlayer.AddToken(column);
        playCount++;
        currentPlayer = playCount % 2 == 0 ? player1 : player2;
      }
    }

    // string? input;

    // Console.WriteLine("1 or 2 players?");

    // do
    // {
    //     input = Console.ReadLine();
    // } while (!int.TryParse(input, out int players) || (players != 1 && players != 2));

    //6 rows, 7 columns

  }
}
