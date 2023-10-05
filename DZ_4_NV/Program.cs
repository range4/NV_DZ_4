using System;


namespace DZ_4_NV
{
    internal class Program
    {
        static void Maxx(int a, int b)
        {
            int res = Math.Max(a, b);
            if (a==b)
            {
                Console.WriteLine("Числа равны");

            }
            else
            {
                Console.WriteLine($"Максимальное число :{res}\n");
            }
        }

        static void Swap(ref int n1, ref int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            
        }


        static bool Factorial(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c;i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch
                {
                    return false;

                }
                return true;
        }

        static int FactRec(int N)
        {
            if (N==0)
            {
                return 0;
            }
            if (N==1)
            {
                return 1;
            }
            return N * FactRec(N - 1);
        }



        static int GetNOD(int a, int b)
        {
            while (b != 0)
            {
                var x = b;
                b = a % b;
                a = x;

            }
            return a;

        }
        static int GetNOD(int a, int b, int c)
        {
            if ((a != 0 && b != 0 && c != 0))
                return GetNOD(GetNOD(a, b), c);
            else
                return a + b + c;
        }



        static int FibRec(int n)
        {
            int[] array = new int[100];
            if (n <= 1)
                return 1;
            else if (array[n] != 0)
                return array[n];
            array[n] = FibRec(n - 2) + FibRec(n - 1);
            return array[n];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 5.1 Макс\nВведите первое число: \n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: \n");
            int b = Convert.ToInt32(Console.ReadLine());
            Maxx(a, b);

            Console.WriteLine("Упражнение 5.2 Свап\nВведите первое число\n");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число\n");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n1 -> {n1} , n2 -> {n2}");
            Swap(ref n1,ref n2);
            Console.WriteLine($"n1 -> {n1} , n2 -> {n2}");

            Console.Write("Упражнение 5.3 Факториал\nВведите целое число :\n");
            int q = Convert.ToInt32(Console.ReadLine());
            bool flag = Factorial(ref q);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(q));


            Console.WriteLine("Упражнение 5.4 ФактРек\nВведите целое число :\n");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал = {FactRec(N)}");





            Console.WriteLine("ДЗ_1  НОД\nВведите 1 число\n");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число\n");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель для чисел {a1} и {b1} это: {GetNOD(a1, b1)}\n");
            Console.WriteLine("Метод для 3 чисел\nВведите 1 число:\n");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число:\n");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 число:\n");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель для чисел {number1}, {number2} и {number3} это {GetNOD(number1, number2, number3)}\n");


            Console.WriteLine("ДЗ_2 Фибо\nВведите номер числа который хотите найти:\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Числом под номером {n} является {FibRec(n)}");


            Console.ReadKey();
        }
    }
}
