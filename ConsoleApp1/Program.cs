//Enter three numbers and swap their values: a to b, b to c, c to a.

// Read three integers from user input
Console.WriteLine("Enter three numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

// Swap the values: a -> b, b -> c, c -> a
int z = b;
b = c;
c = a;
a = z;

// Output the swapped values
Console.WriteLine("Numbers after swapping:");
Console.WriteLine($"{a} {b} {c}");

//Емельяненко