class PascalTriangle
{
  static void Main(string[] args)
  {
    int n = 7;
 
    for (int y = 0; y < n; y++)
    {
      int c = 1;
      for (int q = 0; q < n - y; q++)
      {
        System.Console.Write("   ");
      }
 
      for (int x = 0; x <= y; x++)
      {
        Console.Write("   {0:D} ", c);
        c = c * (y - x) / (x + 1);
      }
      Console.WriteLine();
    }
    Console.WriteLine();
    }
}