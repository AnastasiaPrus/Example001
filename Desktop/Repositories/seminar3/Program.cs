// Задача 17: По двум заданным числам проверять является ли одно квадратом другого.

// Задача 19: Определить номер четверти плоскости, 
    //в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// Задача 21: Программа проверяет пятизначное число на палиндромом.

// Задача 23: Показать таблицу квадратов чисел от 1 до N

// Задача 17: По двум заданным числам проверять является ли одно квадратом другого.

// int a = new Random().Next(1, 99);
// int b = new Random().Next(1, 99);

int a = 5;
int b = 25;

// if (a == b*b || b == a*a)
// {
//     Console.WriteLine("является");
// }

// else
// {
//     Console.WriteLine("не является");
// }

// Console.WriteLine( "a=" + a + " b=" + b);

if (a == b*b) Console.WriteLine($"Число {a} является квадратом числа {b}");
else Console.WriteLine($"Число {a} не является квадратом числа {b}");

if (b == a*a) Console.WriteLine($"Число {b} является квадратом числа {a}");
else Console.WriteLine($"Число {b} не является квадратом числа {a}");


// Задача 19: Определить номер четверти плоскости, 
    //в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = new Random().Next(-99, 99);
int y = new Random().Next(-99, 99);
Console.WriteLine( "x=" + x + " y=" + y);

if (x != 0 && y != 0)
{
if (x>0 && y>0) Console.WriteLine("Точка в первой четверти");
if (x<0 && y>0) Console.WriteLine("Точка во второй четверти");
if (x<0 && y<0) Console.WriteLine("Точка в третьей четверти");
if (x>0 && y<0) Console.WriteLine("Точка в четвертой четверти");
}
else Console.WriteLine("Точка на оси координат");

// Задача 21: Программа проверяет пятизначное число на палиндромом. 12321

Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());

if (n/10000 == n%10 && n/1000%10 == n%100/10) Console.WriteLine("Число палиндром");
else Console.WriteLine("Число не является палиндромом");

// Программа проверяет пятизначное число на палиндромом.
// int number = new Random().Next(10000, 99999);
// String s = number.ToString();
// Console.WriteLine("Число: " + number);
// if (s[0] == s[4] && s[1] == s[3])
// {
// Console.WriteLine("Число - палиндром");
// }
// else
// Console.WriteLine("Число - не палиндром");


// Задача 23: Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите N: ");
int n1 = int.Parse(Console.ReadLine());

for(int i=1; i<=n1; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i*i}");
}

Console.WriteLine();


// Console.WriteLine("Введите N: ");
// int n2 = int.Parse(Console.ReadLine());

for(int i=1; i<=n1; i++)
{
    Console.Write($" \t {i} ");
}

Console.WriteLine();

for(int i=1; i<=n1; i++)
{
    Console.Write($" \t {i*i} ");
}

Console.WriteLine();