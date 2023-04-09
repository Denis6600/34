//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] result = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
}

int Getcount(int[] array, int min, int max)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;

    return (count);
}

int[] array = FillArray(12, 100, 999);
int count = Getcount(array, 10, 99);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"колличество: {count}");