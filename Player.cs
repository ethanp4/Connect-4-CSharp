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

  public void AddToken(int col)
  {
    //necessary checks will be done before this function is called
    grid.AddToken(new Token(this), col - 1);
  }

  public override string ToString()
  {
    return player == 1 ? "X" : "O";
  }

}