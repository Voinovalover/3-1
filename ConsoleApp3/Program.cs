//1)
using System;

class HelloWorld
{
    static void Main()
    {
        int[] array = { 10, 50, 120, -70, 200, 50 };
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;
        int[] newArray = new int[array.Length];
        int newArrayIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 100)
            {
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
            }
            if (!ExistsInArray(newArray, array[i]))
            {
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
            }
        }
        Array.Resize(ref newArray, newArrayIndex);
        Console.WriteLine("Среднее значение в массиве: " + average);
        Console.WriteLine("Массив без элементов, больших 100 по модулю и без повторяющихся элементов: " + string.Join(", ", newArray));
    }
    static bool ExistsInArray(int[] array, int element)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                return true;
            }
        }
        return false;
    }
}
//2)
//3)
