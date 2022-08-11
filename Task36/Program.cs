﻿int[] FillArrayRand(int size, int leftRange, int rightRange){
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = FillArrayRand(4, 0, 100);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int sum = 0;
for (int i = 1; i < array.Length; i += 2){
    sum += array[i];
}
Console.Write($"Cумма нечётных элементов: {sum}");

