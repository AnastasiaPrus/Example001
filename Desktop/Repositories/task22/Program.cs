// Задача 22: Найти расстояние между точками в пространстве 2D/3D
// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2
// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


int xa = new Random().Next(1, 99);
int ya = new Random().Next(1, 99);
int xb = new Random().Next(1, 99);
int yb = new Random().Next(1, 99);
int za = new Random().Next(1, 99);
int zb = new Random().Next(1, 99);

Console.WriteLine( "xa=" + xa + " ya=" + ya + " xb=" + xb + " yb=" + yb + " za=" + za + " zb=" + zb);

Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2))}");

Console.WriteLine($"Расстояние между двумя точками в пространстве равно {Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)+ Math.Pow(zb - za, 2))}");