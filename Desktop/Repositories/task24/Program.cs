// Показать таблицу умножения (лекция)

// for(int a=2; a<=10; a++)
// {
//     for(int b=2; b<=10; b++)
//     {
//         Console.WriteLine($"{a}*{b}={a*b}");
//     }
//     Console.WriteLine();
// }

// Задача 24: Найти кубы чисел от 1 до N

Console.WriteLine("Введите N: ");
int n1 = int.Parse(Console.ReadLine());

for(int i=1; i<=n1; i++)
{
    Console.WriteLine($"Куб числа {i} = {i*i*i}");
}

Console.WriteLine();

for(int i=1; i<=n1; i++)
{
    Console.Write($" \t {i} ");
}

Console.WriteLine();

for(int i=1; i<=n1; i++)
{
    Console.Write($" \t {i*i*i} ");
}

Console.WriteLine();
