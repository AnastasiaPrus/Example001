// Задача 2: Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

if (n>m)
{
    Console.WriteLine("max= "+ n );
    Console.WriteLine("min= "+ m );
}
else 
{
    Console.WriteLine("max= "+ m );
    Console.WriteLine("min= "+ n );
}


