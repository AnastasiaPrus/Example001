// Задача 2: Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число : ");
int a = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int b = Convert.ToUInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
if (a < b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);   
}


