class Program
{
  static void Main()
  {
    Console.Clear();
    PrintStringCharByChar("Connect 4");
    Thread.Sleep(1500);

    Game game = new(2);
    bool keepPlaying;
    do
    {
      keepPlaying = game.Play();
    } while (keepPlaying);
  }

  public static void PrintStringCharByChar(string str)
  {
    foreach (char c in str)
    {
      Console.Write(c);
      Thread.Sleep(40);
    }
  }
}
