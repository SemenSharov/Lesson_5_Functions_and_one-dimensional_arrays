// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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


int oddNumbers(int[] array) //Ищем сумму начетных элементов массива
{
    int sumOddNumbers = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 1) //проверяет четное число
        {
            sumOddNumbers += array[i];
        }

    }
    return sumOddNumbers;
}
Console.WriteLine(oddNumbers(array));