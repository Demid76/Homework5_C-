﻿int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange){
    Random rand = new Random();
   int[] arr = new int[size];
   for (int i = 0; i < arr.Length; i++){
    arr[i] = rand.Next(leftRange, rightRange + 1);
   }
   return arr;
}
int[] array =FillArrayWithRandomNumbers(10, 100, 1000);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int count =0;
for (int i = 0; i < array.Length; i++){
    if (array[i]%2==0){
        count = count + 1;
    }
}
Console.Write($"Количество четных чисел в массиве = {count}");