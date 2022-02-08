// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

int a = 7;
int b = 8;

int index = n;

if ((array[index] == b) || (array[index] == a)) 
    Console.WriteLine("День недели является выходным" );

    else
{
    Console.WriteLine("День недели неявляется выходным");
}
