Console.WriteLine("Set the size of the array"); // Пользователь может сам задать размер массива
int a = int.Parse(Console.ReadLine());

int[] Array = new int[a]; // Инициализация массива
Random rnd = new Random(); 
for (int i=0; i<a; i++)
{
Array[i] = rnd.Next(0,99);  // Заполнение через цикл элементами от 0 до 99
Console.Write($"{Array[i]} "); // Вывод 
}