using System.Runtime.CompilerServices;

class Grid
{
  // 6 rows, 7 columns
  const int rows = 6;
  const int cols = 7;


  private Token[,] grid = new Token[rows, cols];

  public void PrintGrid(bool fullColumn = false)
  {
    Console.Clear();

    if (fullColumn)
    {
      Console.WriteLine("That column is full or doesnt exist\n");
    }

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
    int desiredRow = 0;
    for (int r = rows - 1; r >= 0; r--)
    {
      if (grid[r, col] == null)
      {
        desiredRow = r;
        break;
      }
    }

    for (int i = 0; i <= desiredRow; i++)
    {
      if (i != 0)
      {
        grid[i - 1, col] = null;
      }
      grid[i, col] = token;
      PrintGrid();
      Thread.Sleep(100);
    }
  }


  public bool IsColumnFull(int col)
  {
    if (col < 1 || col > cols)
    {
      return true;
    }
    return grid[0, col - 1] != null;
  }
}