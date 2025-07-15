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
      int modulus = Modulus();
      int times2 = Multiple2(x, y);
      Console.WriteLine($"hasil tambah nya adalah {plus}");
      Console.WriteLine($"hasil perkalian nya adalah {times}");
      Devide();
      Console.WriteLine($"20 % 3 adalah {modulus}");
      Add2(x, y);
      Console.WriteLine($"hasil perkalian nya adalah {times2}");
      Overloading();
      Console.WriteLine($"hasil tambah 10.5 dan 25.6 {Add3(10.5f, 25.6f)}");
    }
    static int Add(int a, int b)
    {
      int sum = a + b;
      return sum;
    }
    static int Multiple(int a, int b)
    {
      int sum = a * b;
      return sum;
    }
    // no arguments and no return
    static void Devide()
    {
      int x = 10;
      int y = 20;
      int devide = y / x;
      Console.WriteLine($"hasil pembagiannya adalah {devide}");
    }
    // no arguments but return value
    static int Modulus()
    {
      int x = 20;
      int y = 3;
      int sum = x % y;
      return sum;
    }
    // arguments but no return
    static void Add2(int x, int y)
    {
      int sum = x + y + y;
      Console.WriteLine($"Hasil penjumlahan x + y + y adalah {sum}");
    }
    // arguments and return
    static int Multiple2(int x, int y)
    {
      int sum = x * y;
      return sum;
    }
    // function overloading adalah ketika kita membuat lebih dari 1 function dengan nama yang sama tapi mempunya perbedaan parameters.
    static void Overloading()
    {
      int a = 10, b = 2, c, d;
      c = Tambah(a, b);
      Console.WriteLine($"sum of {a} + {b} is {c}");
      d = Tambah(a, b, c);
      Console.WriteLine($"sum of {a} + {b} + {c} is {d}");
    }
    static int Tambah(int x, int y)
    {
      return x + y;
    }
    static int Tambah(int x, int y, int z)
    {
      return x + y + z;
    }
    static float Add3(float x, float y)
    {
      return x + y;
    }
  }
}