// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
// Задача 44: Найти точку пересечения двух прямых заданных уравнением 
//            y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
// Задача 46: Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

//46
Console.Clear();
Console.WriteLine("Задача 46: Написать программу масштабирования фигуры.");
Console.WriteLine(" ");


int xa = 2, ya = 2,
    xb = 2, yb = 4,
    xc = 4, yc = 2,
    xd = 4, yd = 4;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

Console.WriteLine("Введите коэфициент k= ");
int k = int.Parse(Console.ReadLine());

xa = xa*k;
ya = ya*k;
xb = xb*k;
yb = yb*k;
xc = xc*k; 
yc = yc*k;
xd = xd*k;
yd = yd*k;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("*");

Console.WriteLine($"Вершины ({xa};{ya}),({xb};{yb}),({xc};{yc}),({xd};{yd})");


//42
Console.WriteLine("Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.");
Console.WriteLine(" ");

static void Positive()
{
    Console.Write("Сколько чисел вы хотите ввести? N= ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    int count = 0;
    for(int i = 0; i < n; i++)
    {
        Console.Write($"A[{i + 1}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        if (a[i]>0) count++; 
    }
    Console.WriteLine($"С клавиатуры введено {count} чисел больше нуля");
}

Positive();
Console.WriteLine(" ");

//44
Console.WriteLine("Задача 44: Найти точку пересечения двух прямых заданных уравнением");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 задан");
Console.WriteLine(" ");

Random rand = new Random();
int k1 = rand.Next(1, 10);
Console.WriteLine("k1="+k1);
int k2 = rand.Next(1, 10);
Console.WriteLine("k2="+k2);
int b1 = rand.Next(1, 10);
Console.WriteLine("b1="+b1);
int b2 = rand.Next(1, 10);
Console.WriteLine("b2="+b2);

int x1 = (b2-b1)/(k1+k2);
int y1 = ((k1*x1) + b1);

Console.WriteLine($"точка пересечения ({x1};{y1})");


