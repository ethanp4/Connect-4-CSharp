class Program
{
  static void Main()
  {
    Grid grid = new Grid();
    Player player1 = new Player(grid, 1);
    Player player2 = new Player(grid, 2);


    grid.PrintGrid();

    player1.AddToken(grid, 1);
    player1.AddToken(grid, 1);

    grid.PrintGrid();

    // string? input;

    // Console.WriteLine("1 or 2 players?");

    // do
    // {
    //     input = Console.ReadLine();
    // } while (!int.TryParse(input, out int players) || (players != 1 && players != 2));

    //6 rows, 7 columns

  }
}
