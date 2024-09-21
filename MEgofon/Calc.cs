using System;

namespace Project
{
    class Program
    {
        static void Main()
        {

            Console.Write("введите кол-во чисел от 2 до 1000: ");
            int WhatNum = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();

            for (int i = 1; i < WhatNum + 1; i++)
            {
                Console.Write("Введите " + i + " число: ");
                double num = double.Parse(Console.ReadLine());
                nums.Add(num);
            }
            Console.Write("Введите действие которое хотите совершить (1: +, 2: -, 3: *, 4: /) ");
            int deestvie = int.Parse(Console.ReadLine());

            switch(deestvie)
            {
                case 1:
                    foreach (var pp in nums)
                    {
                        Console.WriteLine("Ваши числа: " + pp);
                    }
                    Console.Write("Складываем все числа");
                    double sum = nums.Sum();
                    Console.WriteLine("Ваш результат: " + sum);
                    break;
                case 2:
                    foreach (var pp in nums)
                    {
                        Console.WriteLine("Ваши числа: " + pp);
                    }
                    double resultMines = nums[0];
                    for (int i = 1; i < WhatNum; i++)
                    {
                        resultMines -= nums[i];
                    }
                    Console.WriteLine("Делаем вычитаение: ");
                    Console.WriteLine("Результат: " + resultMines);
                    break;
                case 3:
                    foreach (var pp in nums)
                    {
                        Console.WriteLine("Ваши числа: " + pp);
                    }
                    double resultMnoj = nums[0];
                    for (int i = 1; i < WhatNum; i++)
                    {
                        resultMnoj *= nums[i];
                    }
                    Console.WriteLine("Умножаем: ");
                    Console.WriteLine("Результат: " + resultMnoj);
                    break;
                case 4:
                    foreach (var pp in nums)
                    {
                        Console.WriteLine("Ваши числа: " + pp);
                    }
                    double resultDel = nums[0];
                    for (int i = 1; i < WhatNum; i++)
                    {
                        resultDel = resultDel / nums[i];
                    }
                    Console.WriteLine("Делим: ");
                    Console.WriteLine("Результат: " + resultDel);
                    break;

            }

        }
    }
}