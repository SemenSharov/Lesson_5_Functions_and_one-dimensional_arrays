// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива :  ");

double[] GenerateArray(int sizeRandomArray) //
{
    double[] arrayRandom = new double[sizeRandomArray];//создали массив
    Random rnd = new Random();//создали объект rnd класс Random
    for (int i = 0; i < sizeRandomArray; i++)//заполнили элементы массива рандомными числами
    {
        arrayRandom[i] = Convert.ToDouble(rnd.Next(100) / 10.0);
    }
    return arrayRandom;//вернули значение 
}
double[] array = GenerateArray(Convert.ToInt32(Console.ReadLine())); //присвоили рандомное значение массива
Console.WriteLine(String.Join(" | ", array)); // выводим массив в строку



double minNumbers(double[] array)
{
    int length = array.Length;
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (min > array[i])
        {
            min = array[i];

        }
    }
    return min;
}
double maxNumbers(double[] array)
{
    int length = array.Length;
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
Console.WriteLine(maxNumbers(array) - minNumbers(array));
