// Задача 34: Написать программу для замены элементов массива на противоположные.

// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.

// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.


//Функция заполнения массива
int[] array = new int[7];
void MassiveRandom (int[] mass)
{
    for (int x = 0; x < array.Length; x++)
        {
            array[x] = new Random().Next(0,10);
        }
}

//Функция вывода массива
void MassiveOutput (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]+" ");
    }
}

//34
Console.WriteLine("адача 34: Написать программу для замены элементов массива на противоположные.");
Console.WriteLine("");

MassiveRandom (array);
MassiveOutput(array);
Console.WriteLine("");

void Opposite (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.WriteLine($"Противоположное {mass[i]} = {mass[i]*(-1)}");
    }
}

Opposite (array);
MassiveOutput(array);

//36
Console.WriteLine("Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами.");
Console.WriteLine("           Показать количество нечётных/чётных чисел.");
Console.WriteLine("");

//Функция заполнения массива
int[] array1 = new int[7];
void MassiveRandom1 (int[] mass1)
{
    for (int x = 0; x < array1.Length; x++)
        {
            array1[x] = new Random().Next(99,1000);
        }
}

//Функция вывода массива
void MassiveOutput1 (int[] mass1)
{
    for (int i = 0; i < mass1.Length; i++)
    {
        Console.Write(mass1[i]+" ");
    }
}

void NumbersEvenOdd1 (int[] mass1)
{
    int count = 0;
    int count1 = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i] % 2 == 0)
        {
            count++;
        }
        else count1++;
    }
    Console.WriteLine ("Четных " + count);
    Console.WriteLine ("Нечетных " + count1);
}

MassiveRandom1 (array1);
MassiveOutput1(array1);
Console.WriteLine("");
NumbersEvenOdd1 (array1);
Console.WriteLine("");

//38
Console.WriteLine("Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции. ");
Console.WriteLine("");

void SummNumbersOdd (int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + mass[i];
        }
    }
    Console.WriteLine ("Сумма равна " + sum);
}

MassiveRandom1 (array);
MassiveOutput1(array);
Console.WriteLine("");
SummNumbersOdd (array);
Console.WriteLine("");


//40
Console.WriteLine("Задача 40: В указанном массиве вещественных чисел найти разницу ");
Console.WriteLine("           между максимальным и минимальным элементами.");
Console.WriteLine("");

// array[i] = max;
// array[j] = min;

//Функция заполнения массива
int[] array2 = new int[10];
void MassiveRandom2 (int[] mass2)
{
    for (int x1 = 0; x1 < array2.Length; x1++)
        {
            array2[x1] = new Random().Next(5,100);
        }
}

//Функция вывода массива
void MassiveOutput2 (int[] mass2)
{
    for (int i1 = 0; i1 < mass2.Length; i1++)
    {
        Console.Write(mass2[i1]+" ");
    }
}


MassiveRandom2 (array2);
MassiveOutput2(array2);
Console.WriteLine("");

double max = 0;
int i = 0;
double min = array2[i];
while ( i < array2.Length) 
{
    
    if (array2[i] > max ) max = array2[i];
    if (array2[i] < min ) min = array2[i];
    i++;
}
Console.WriteLine ($"макс= {max}; мин= {min}");

Console.WriteLine ($"Разница между максимальным {max} и минимальным {min} равно  {max - min}" );

