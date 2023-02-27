// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] array = GetArray(10, 100, 999);
Console.WriteLine($"В массиве [ {String.Join(" | ", array )} ]");//Вывод массива в консоль

int[] GetArray (int size, int minValue, int maxValue)//Создал массив
{
    int[]result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;

}
int count = 0;// Ввел дополнительную переменную для кол-ва четных чисел
for (int i = 0; i < array.Length ; i++)
{
    if (array[i] % 2 == 0)//Поиск количества четных элементов
    count++;
}
Console.WriteLine($"Из {array.Length} чисел, имеется  {count} четных ");