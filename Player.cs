class Player
{
  private readonly int player;
  private readonly Grid grid;
  public Player(Grid grid, int player)
  {
    this.grid = grid;
    this.player = player;
  }

  public int GetPlayer()
  {
    return player;
  }

  public bool AddToken(Grid grid, int col)
  {
    if (grid.IsColumnFull(col))
    {
      return false;
    }
    if (col < 1 || col > 7)
    {
      return false;
    }

    grid.AddToken(new Token(this), col - 1);
    return true;
  }

}