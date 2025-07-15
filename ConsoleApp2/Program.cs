// See https://aka.ms/new-console-template for more information
// Pertanyaan untuk detail engineer
Console.WriteLine("Enter Engineer Details ");
Console.WriteLine("Enter Engineer ID");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Engineer Name");
string? name = Console.ReadLine()?.ToUpper();
Console.WriteLine("Enter Engineer Salary");
int salary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Engineer Address");
string? address = Console.ReadLine();
Console.WriteLine("Enter Engineer Department");
string? department = Console.ReadLine();

// menampilkan data engineer
Console.WriteLine("\n Engineer Details are as Follows: ");
Console.WriteLine($"Engineer ID is {id}");
Console.WriteLine($"Engineer Name is {name}");
Console.WriteLine($"Engineer Salary is {salary}");
Console.WriteLine($"Engineer Address is {address}");
Console.WriteLine($"Engineer Department is {department}");

// Pertanyaan untuk santri
Console.WriteLine("Enter a student details :");
Console.WriteLine("Enter Registration Santri");
int regist = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Name Santri");
string? nameSantri = Console.ReadLine()?.ToUpperInvariant();
Console.WriteLine("Enter 3 Nilai Mapel");
Console.WriteLine("Mapel 1");
int mark1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mapel 2");
int mark2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mapel 3");
int mark3 = Convert.ToInt32(Console.ReadLine());

int totalMark = mark1 + mark2 + mark3;
int averageMark = totalMark / 3;

// menampilkan raport santri
Console.WriteLine("\n Santri Details are as follows :");
Console.WriteLine($"Registration Santri is {regist}");
Console.WriteLine($"Santri Name is {nameSantri}");
Console.WriteLine($"Nilai Mapel 1 is {mark1}");
Console.WriteLine($"Nilai Mapel 2 is {mark2}");
Console.WriteLine($"Nilai Mapel 3 is {mark3}");
Console.WriteLine($"Rata - rata Nilai nya {averageMark}");
Console.WriteLine($"Total Nilai nya {totalMark}");
