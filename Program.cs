// ДЗ к Уроку 5 (Функции продолжение)
// Все массивы от 5-ти элементов


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(9, 100, 1000);
Console.WriteLine(String.Join(", ", array));

int chetNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        chetNumbers++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве = {chetNumbers}.");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(9);
Console.WriteLine(String.Join(" ", array));

int summNechet = 0;

for (int i = 0; i < array.Length; i+=2)
{
   summNechet = summNechet + array[i];
} 

Console.WriteLine($"Сумма элементов на нечетных позициях равна {summNechet} ");


int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100);
    }
    return res;
}
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

float[] array = GetArray(9);
Console.WriteLine(String.Join(", ", array));

float maxArray = array[0];
float minArray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minArray)
    {
        minArray = array[i];
    }
    else if (array[i] > maxArray)
    {
        maxArray = array[i];
    }
}

Console.WriteLine($"Разница между максимальным (={maxArray}) и минимальным (={minArray}) элементами массива равна {maxArray - minArray} ");


float[] GetArray(int size)
{
    float[] res = new float[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1000);
    }
    return res;
}

*/