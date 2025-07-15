// See https://aka.ms/new-console-template for more information


// modular or procedural programming

// static void Main(string[] args)
// {
//   int n;
//   Console.WriteLine("Enter a Positive Integer");
//   n = Convert.ToInt32(Console.ReadLine());
//   bool isPrima = isPrima(n);
//   if (isPrima)
//   {
//     Console.WriteLine($"{n} is a bilangan prima");
//   }
//   else
//   {
//     Console.WriteLine($"{n} is not a bilangan prima");
//   }
// }

// class Programs
// {
//   private static bool isPrima(int n)
//   {
//     bool isPrima = true;
//     // 0 and 1 tidak bilangan prima
//     if (n == 1 || n == 0)
//     {
//       isPrima = false;
//     }
//     else
//     {
//       for (int i = 2; i <= n / 2; ++i)
//       {
//         if (n % i == 0)
//         {
//           isPrima = false;
//           break;
//         }
//       }
//     }
//     return isPrima;
//   }
// }



// monolithic programming

// int i, n;
// bool isPrima = true;
// Console.WriteLine("Enter a Positive Integer: ");
// n = Convert.ToInt32(Console.ReadLine());

// 0 and 1 bukan bilangan prima
// if (n == 0 || n == 1)
// {
//   isPrima = false;
// }
// else
// {
//   for (i = 2; i <= n / 2; ++i)
//   {
//     if (n % i == 0)
//     {
//       isPrima = false;
//       break;
//     }
//   }
// }
// if (isPrima)
// {
//   Console.WriteLine($"{n} is a Prime Number");
// }
// else
// {
//   Console.WriteLine($"{n} is not a Prime Number");
// }

// type basic
// string pesan = "Tahun Lahir";
// string finalPesan = pesan.ToUpper();
// int tahunLahir = 2001;
// string tahunLahirr = tahunLahir.ToString();
// Console.WriteLine(finalPesan + " " + tahunLahirr);

// int satuKM = 900;
// bool isItAKM = satuKM >= 1000;
// if (isItAKM)
// {
//   Console.WriteLine("Ini 1KM atau bahkan lebih");
// }

// Division
// int num = 2 / 3;
//int b = 0;
//int c = 5 / b; //Throws DevideByZeroExpection at run time;
//int d = 5 / 0; //Compile-time error
// Console.WriteLine(c);

// Overflow
// int num = int.MinValue;
// num--;
// Console.WriteLine(num == int.MaxValue);
// int num2 = int.MaxValue;
// num2++;
// Console.WriteLine(num2 == int.MinValue);

// int num3 = 1000000;
// int num4 = 1000000;
// Console.WriteLine(checked(num3 * num4));