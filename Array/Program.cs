using System;

class Program
{
    static void Main()
    {
        // Создаем объект класса Random для генерации случайных чисел
        Random rand = new Random();

        // Задаем длину массива
        int arrayLength = 10;

        // Создаем массив
        int[] numbers = new int[arrayLength];

        // Заполняем массив случайными числами от 0 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 101); // Генерация числа в диапазоне от 0 до 100
        }

        // Выводим массив на экран
        Console.WriteLine("Массив случайных чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        // Ищем максимальный элемент и его индекс
        int max = numbers[0];
        int maxIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
                maxIndex = i;
            }
        }

        // Выводим результат
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
    }
}
