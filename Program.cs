class Program
{
    static void Main()
    {
        const int rows = 6;
        const int cols = 7;
        // string? input;

        // Console.WriteLine("1 or 2 players?");

        // do
        // {
        //     input = Console.ReadLine();
        // } while (!int.TryParse(input, out int players) || (players != 1 && players != 2));

        //6 rows, 7 columns
        int[,] board = new int[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write($"Row {r}, Column {c}, Val {board[r, c]}\n");
            }
        }
    }
}