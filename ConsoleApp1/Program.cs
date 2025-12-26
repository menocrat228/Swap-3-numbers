Console.WriteLine("Enter three numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int z = b;
b = c;
c = a;
a = z;
Console.WriteLine("Numbers after swapping:");
Console.WriteLine($"{a} {b} {c}");

//Емельяненко