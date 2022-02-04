// Задача 8: Показать чётные числа от 1 до N.

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int m = 2 ;
while (m <= n) 
{ 
    //if (m % 2 == 0 )
    { 
    Console.WriteLine( m );
    m +=2 ;
    } 
}

