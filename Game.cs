class Game
{
  private readonly Grid grid;
  private readonly Player[] players;

  public Game(int playerCount)
  {

  }

  public void Play()
  {
    Grid grid = new Grid();
    Player player1 = new Player(grid, 1);
    Player player2 = new Player(grid, 2);

    grid.PrintGrid();

    int playCount = 0;

    Player currentPlayer = player1;
    int column;
    while (!CheckWin())
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
  }

  public bool CheckWin()
  {
    return false;
  }
}