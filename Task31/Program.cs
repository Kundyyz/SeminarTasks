int GetSumNegativeElem (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int GetSumPositiveElem (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}
int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
        if(array[i] < 0) sumNegative += array[i];
    }
    return new int[]{sumPositive, sumNegative};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
Console.WriteLine();
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");