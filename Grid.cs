using System.Runtime.CompilerServices;

class Grid
{
  // 6 rows, 7 columns
  const int rows = 6;
  const int cols = 7;


  private Token[,] grid = new Token[rows, cols];

  public void PrintGrid(int errorMsg = 0)
  {
    Console.Clear();

    switch (errorMsg)
    {
      case 1:
        Console.WriteLine("That column is full\n");
        break;
      case 2:
        Console.WriteLine("Enter a number between 1 and 7\n");
        break;
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

    //this finds the lowest row that is empty
    for (int r = rows - 1; r >= 0; r--)
    {
      if (grid[r, col] == null)
      {
        desiredRow = r;
        break;
      }
    }

    //this "moves" the token downwards from the top of the grid
    //updating each time to animate it
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
    return grid[0, col - 1] != null;
  }
}