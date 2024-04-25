class Player
{
  private readonly bool player;
  private readonly Grid grid;
  public Player(Grid grid, int player)
  {
    //the datatype of bool but this constructor will take in an int instead
    switch (player)
    {
      case 1:
        this.player = true;
        break;
      case 2:
        this.player = false;
        break;
    }
    this.grid = grid;
  }

  public void AddToken(int col)
  {
    //necessary checks will be done before this function is called
    grid.AddToken(new Token(this), col - 1);
  }

  public override string ToString()
  {
    return player ? "X" : "O";
  }

}