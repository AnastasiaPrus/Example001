// Задача 6: Выяснить является ли число чётным

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0 )
{ 
    Console.WriteLine("Число чётное ");
} 

else
{
   Console.WriteLine("Число нечётное "); 
}