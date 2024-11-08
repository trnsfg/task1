using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");


            //завдання 2
            //Console.WriteLine("input 5 numbers");
            //int var1 = int.Parse(Console.ReadLine());
            //int var2 = int.Parse(Console.ReadLine());
            //int var3 = int.Parse(Console.ReadLine());
            //int var4 = int.Parse(Console.ReadLine());
            //int var5 = int.Parse(Console.ReadLine());

            //int sum = var1 + var2 + var3 + var4 + var5;
            //int dobutok = var1 * var2 * var3 * var4 * var5;

            //int max = var1;
            //if (var2 > max) max = var2;
            //if (var3 > max) max = var3;
            //if (var4 > max) max = var4;
            //if (var5 > max) max = var5;

            //int min = var1;
            //if (var2 < min) min = var2;
            //if (var3 < min) min = var3;
            //if (var4 < min) min = var4;
            //if (var5 < min) min = var5;


            //Console.WriteLine(sum);
            //Console.WriteLine(dobutok);
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            //завдання 3
            //Console.WriteLine("input six-digit number");
            //int var = int.Parse(Console.ReadLine());
            //int result = (var % 10) * 100000 + (var / 10 % 10) * 10000 + (var / 100 % 10) * 1000 + (var / 1000 % 10) * 100 + (var / 10000 % 10) * 10 + (var / 100000);
            //Console.WriteLine(result);

            //завдання 4
            //Console.WriteLine("input first number");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("input second number");
            //int num2 = int.Parse(Console.ReadLine());

            //int a = 0;
            //int b = 1;

            //while(a <= num2)
            //{
            //    if (a >= num1)
            //    {
            //        Console.Write(a + " ");
            //    }

            //    int temp = a + b;
            //    a = b;
            //    b = temp;
            //}


            //завдання 5
            //int A = 3;
            //int B = 7;
            //for (int i = A; i <= B; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}

            //завдання 6
            Console.WriteLine("input the lenght of line");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("input symbol");
            string symbol = Console.ReadLine();

            Console.WriteLine("input line direction(vertically - v or horizontally - h)");
            string direction = Console.ReadLine();

            if (direction == "h")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            else if (direction == "v")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
