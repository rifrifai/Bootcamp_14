// See https://aka.ms/new-console-template for more information
namespace ConsoleApp4
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y;
      x = 10;
      y = 15;
      int plus = Add(x, y);
      int times = Multiple(x, y);
      Console.WriteLine($"hasil tambah nya adalah {plus}");
      Console.WriteLine($"hasil perkalian nya adalah {times}");
    }
    static int Add(int a, int b)
    {
      int sum = a + b;
      return sum;
    }
    static int Multiple(int c, int d)
    {
      int sum = c * d;
      return sum;
    }
  }
}