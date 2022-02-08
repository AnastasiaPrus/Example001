// Задача 12: Удалить вторую цифру трёхзначного числа.

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write(a/100);
Console.Write(a%10);