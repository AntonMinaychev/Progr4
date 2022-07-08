Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a degree");
int b = int.Parse(Console.ReadLine());
int tmp = a;  // Временная переменная

if (b == 1)
Console.WriteLine(a);

else

for(int counter = 1; counter < b; counter++) 

{
a *= tmp; // Перемножение с присвоением
}

Console.WriteLine(a);