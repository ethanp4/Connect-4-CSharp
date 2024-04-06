class Token
{
  private readonly Player player;

  public Token(Player player)
  {
    this.player = player;
  }

  public override string ToString()
  {
    return player.ToString();
  }
}