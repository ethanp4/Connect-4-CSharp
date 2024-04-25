class Game
{
  private readonly Grid grid;
  private readonly Player[] players;

  public Game(int playerCount)
  {
    players = new Player[playerCount];
    for (int i = 0; i < playerCount; i++)
    {
      players[i] = new Player(grid, i + 1);
    }
  }

  public bool Play()
  {
    Grid grid = new Grid();
    Player player1 = new Player(grid, 1);
    Player player2 = new Player(grid, 2);

    grid.PrintGrid();

    int playCount = 0;

    Player currentPlayer = player1;
    Player prevPlayer;
    string? input;

    int column;
    do
    {
      Console.WriteLine("Enter a column for {0}", currentPlayer);

      input = Console.ReadLine();

      //if it was not an int or was out of range
      if (!int.TryParse(input, out column) || column < 1 || column > 7)
      {
        grid.PrintGrid(2);
        continue;
      }

      //if it was an int but the column is full
      if (grid.IsColumnFull(column))
      {
        grid.PrintGrid(1);
        continue;
      }

      grid.PrintGrid();
      currentPlayer.AddToken(column);

      playCount++;
      prevPlayer = currentPlayer;
      currentPlayer = playCount % 2 == 0 ? player1 : player2;

      if (playCount >= 42)
      {
        Console.WriteLine("Draw!");
        Console.WriteLine("Play again? (y/n)");
        return Console.ReadLine() == "y";
      }

      if (grid.CheckWin(char.Parse(prevPlayer.ToString())))
      {
        Console.WriteLine("Player {0} has won!", prevPlayer);
        Console.WriteLine("Play again? (y/n)");
        return Console.ReadLine() == "y";
      }
    } while (true);
  }
}