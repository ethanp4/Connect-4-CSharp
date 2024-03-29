class Token
{
  private Player player;

  public Token(Player player)
  {
    this.player = player;
  }

  public override string ToString()
  {
    return player.GetPlayer() == 1 ? "X" : "O";
  }
}