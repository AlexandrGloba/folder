// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// int[] array = GetArray(10, 100, 999);
// Console.WriteLine($"В массиве [ {String.Join(" | ", array )} ]");//Вывод массива в консоль

// int[] GetArray (int size, int minValue, int maxValue)//Создал массив
// {
//     int[]result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result [i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;

// }
// int count = 0;// Ввел дополнительную переменную для кол-ва четных чисел
// for (int i = 0; i < array.Length ; i++)
// {
//     if (array[i] % 2 == 0)//Поиск количества четных чисел
//     count++;
// }
// Console.WriteLine($"Из {array.Length} чисел, имеется  {count} четных ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
//  int[] array = GetArray(10, -10, 10);
//  Console.WriteLine($"В массиве [ {String.Join(" | ", array )} ]");
//  int[] GetArray (int size, int minValue, int maxValue)
//  {
//      int[]result = new int[size];
//      for (int i = 0; i < size; i++)
//      {
//          result [i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return result;
//  }
// int count = 0;
// for (int i = 1; i < array.Length; i+=2)
//     {
//    count = count+array[i];
//     }

//  Console.WriteLine($" {array.Length} чисел. Cумма элементов на нечётных позициях равна  {count}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = GetArray(10, 0.0, 1.0);
 Console.WriteLine($"В массиве [ {String.Join(" | ", array )} ]");//Вывод массива в консоль

double[] GetArray (int size, double minValue, double maxValue)
{
         double[]result = new double[size];
     for (int i = 0; i < size; i++)
     {
         result [i] = new Random().NextDouble();
     }
     return result;
}

double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i]< min)
    {
        min = array[i];
    }
}
double difference = (max-min);
Console.WriteLine($"Разница между максимальным и минимальным значением = {difference}");