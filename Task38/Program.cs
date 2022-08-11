Console.WriteLine("Введите массив вещественных чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите значение элемента массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элеменатми равна: {max - min}");
