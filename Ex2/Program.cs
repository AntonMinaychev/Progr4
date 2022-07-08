Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());
int sum = 0;
while (a > 0)
{
sum = sum + a%10;  // Добавляет к сумме остаток от деления на 10 (фактически последнюю цифру числа)
a = a / 10;        // Из-за типа int автоматически отбрасывается часть после запятой
}
Console.WriteLine(sum);