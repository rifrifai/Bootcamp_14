// See https://aka.ms/new-console-template for more information
// Pertanyaan untuk detail engineer
Console.WriteLine("Enter Engineer Details ");
Console.WriteLine("Enter Engineer ID");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Engineer Name");
string? name = Console.ReadLine();
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
