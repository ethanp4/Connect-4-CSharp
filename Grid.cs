class Grid
{
  // 6 rows, 7 columns
  const int rows = 6;
  const int cols = 7;

  private Token[,] grid = new Token[rows, cols];

  public void PrintGrid()
  {
    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < cols; c++)
      {
        Console.Write(" ");
        Console.Write(grid[r, c] == null ? "#" : grid[r, c].ToString());
      }
      Console.WriteLine();
    }
    Console.Write(" ");
    Console.WriteLine("1 2 3 4 5 6 7");
    Console.WriteLine();
  }

  public void AddToken(Token token, int col)
  {
    for (int r = rows - 1; r >= 0; r--)
    {
      if (grid[r, col] == null)
      {
        grid[r, col] = token;
        return;
      }
    }
  }

  public bool IsColumnFull(int col)
  {
    return grid[0, col] != null;
  }
}