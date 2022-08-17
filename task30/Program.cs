// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8];

// new Random().Next

// Console.WriteLine(arr[0]);

 int [] array = new  int[8];
Random rand = new Random(); // создадим переменную, что б уйти от выделения памяти в цикле

for(int i=0; i < array.Length;i++ )  // обход на заполнения массива
{
    array[i] = rand.Next(0,2); // заполняет 0 и 1, так как 2 индекс значения 1
   
}

      Console.WriteLine(string.Join(" , ", array));

