// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: 1, 2, 3, 4 ");
int x = int.Parse(Console.ReadLine());

if (x==1) Console.WriteLine("Диапазон координат (x>0; y>0)");
if (x==2) Console.WriteLine("Диапазон координат (x<0; y>0)");
if (x==3) Console.WriteLine("Диапазон координат (x<0; y<0)");
if (x==4) Console.WriteLine("Диапазон координат (x>0; y<0)");

