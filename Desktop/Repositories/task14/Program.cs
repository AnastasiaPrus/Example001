// Задача 14: Найти третью цифру числа или сообщить, что её нет.

Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

// int n, a, b, c;
int b;

if (n < 100 || n >= 1000)
{
    Console.Write("Второй цифры нет");
    Console.ReadKey();
    return;
}

Console.WriteLine (b = n % 100 / 10); 
