// 26. Возведите число А в натуральную степень B используя цикл
// 28. Подсчитать сумму цифр в числе
// 30. Показать кубы чисел, заканчивающихся на четную цифру
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("26. Возведите число А в натуральную степень B используя цикл");
Console.WriteLine("Введите число A: ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int b1 = int.Parse(Console.ReadLine());

int c = 1;

for (int i = 1; i <=b1; i++)
{
   c = a1*c;
}

Console.WriteLine($"Число А={a1} в степени В={b1} равно {c}");
Console.WriteLine();

// 28. Подсчитать сумму цифр в числе

Console.WriteLine("28. Подсчитать сумму цифр в числе");
Console.WriteLine("Введите число: ");
int a2 = int.Parse(Console.ReadLine());

int s = 0;
while (a2 > 0)
{
   s = s + a2 % 10;
   a2 = a2 /10 ;
}

Console.WriteLine($"Cуммa цифр в числе {a2} равнa " + s );
Console.WriteLine();

// // 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("30. Показать кубы чисел, заканчивающихся на четную цифру");

   Console.WriteLine("Введите число: ");
   int n1 = int.Parse(Console.ReadLine());

   for(int i=2; i<=n1; i=i+2)
   {
   Console.WriteLine($"Куб числа {i} = {i*i*i}");
   }


// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");


int[] myArray = new int[8];
Random rand = new Random();
            
for (int x = 0; x < myArray.Length; x++)
   {
      myArray[x] = rand.Next(2);
      Console.WriteLine("Значение элемента массива " + x + " = " + myArray[x]);
   }