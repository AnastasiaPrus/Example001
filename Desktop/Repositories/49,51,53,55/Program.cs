// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
// Задача 51: Задать двумерный массив следующим правилом: Amn = m+n.
// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

/*
//49
Console.WriteLine("Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.");
Console.WriteLine(" ");

void PrintArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($" {matr[i, j]}");
}
Console.WriteLine();
}
}

void FillArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().NextDouble()*1000; 
}
}
}
double[,] array = new double[3,4];
FillArray(array);
PrintArray(array);



//51
Console.WriteLine("Задача 51: Задать двумерный массив следующим правилом: Amn = m+n.");
Console.WriteLine(" ");

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($" {matr[i, j]}");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(1, 100); // заполняем числами [0,100)
}
}
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = i+j;
}
}
Console.WriteLine();
PrintArray(array);


//53
Console.WriteLine("Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.");
Console.WriteLine(" ");

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($" {matr[i, j]}");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(1, 100); 
}
}
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);


Console.WriteLine("Введите число");
int find = int.Parse(Console.ReadLine());

bool f = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (find == array[i, j]) { m = i;n = j;f = true; };
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (f)
                Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
            else
                Console.WriteLine("Число не найдено");
 
            Console.ReadKey();
*/
//55
Console.WriteLine("Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
Console.WriteLine(" ");


void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($" {matr[i, j]}");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(1, 10); 
}
}
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(0); j++)
{
sum += array[j, i];
Console.WriteLine(array[j, i]);

}
Console.WriteLine($"Среднее арифметическое {i+1} столбца равно {sum/m}");
sum = 0;
}

Console.WriteLine();
