// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива :  ");
// uint sizeArray = Convert.ToUInt32(Console.ReadLine());

int[] GenerateArray(uint sizeRandomArray) //
{
    int[] arrayRandom = new int[sizeRandomArray];//создали массив
    Random rnd = new Random();//создали объект rnd класс Random
    for (int i = 0; i < sizeRandomArray; i++)//заполнили элементы массива рандомными числами
    {
        arrayRandom[i] = rnd.Next(100, 999);
    }
    return arrayRandom;//вернули значение 
}
int[] array = GenerateArray(Convert.ToUInt32(Console.ReadLine())); //присвоили рандомное значение массива
Console.WriteLine(String.Join(",", array)); // выводим массив в строку


uint evenNumbers(int[] array) //Ищем кол-во четных элементов массива
{
    uint sumEvenNumbers = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) //проверяет четное число
        {
            sumEvenNumbers++;
        }

    }
    return sumEvenNumbers;
}
Console.WriteLine(evenNumbers(array));