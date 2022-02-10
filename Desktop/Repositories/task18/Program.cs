// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = false;

if ((!(x || y)) == (!x && !y))
{
    Console.WriteLine("Выражение истинно");
}
else
{
    Console.WriteLine("Выражение ложно");
}

bool x1 = false;
bool y1 = true;

if ((!(x1 || y1)) == (!x1 && !y1))
{
    Console.WriteLine("Выражение истинно");
}
else
{
    Console.WriteLine("Выражение ложно");
}

bool x2 = true;
bool y2 = true;

if ((!(x2 || y2)) == (!x2 && !y2))
{
    Console.WriteLine("Выражение истинно");
}
else
{
    Console.WriteLine("Выражение ложно");
}

bool x3 = false;
bool y3 = false;

if ((!(x3 || y3)) == (!x3 && !y3))
{
    Console.WriteLine("Выражение истинно");
}
else
{
    Console.WriteLine("Выражение ложно");
}