using System;
using System.Threading;
namespace DZ_4_NV
{
    internal class Program
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;

        }
        public static void Prod(int[] numbers, ref int prod)
        {
            prod = 1;
            foreach (int num in numbers)
            {
                prod *= num;
            }
        }
        public static void Average(int[] numbers, out double average)
        {
            int sum = Sum(numbers);
            average = sum / numbers.Length;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 Массив\n");
            int[] numbers = new int[20];
            Random random = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nВведите номер первого числа:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Введено не число");
            }
            Console.WriteLine("Введите номер второго число:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Введено не число");
            }
            int temp = numbers[num1 - 1];
            numbers[num1 - 1] = numbers[num2 - 1];
            numbers[num2 - 1] = temp;
            Console.WriteLine("Получившийся массив:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }



            Console.WriteLine("\nЗадание 2\n");
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            int prod = 1;
            Prod(numbers, ref prod);
            double average;
            Average(numbers, out average);

            Console.WriteLine($"\nСумма: {Sum(numbers)} \nПроизведение: {prod} \nСреднее арифметическое: {average}");




        }
    }
}

