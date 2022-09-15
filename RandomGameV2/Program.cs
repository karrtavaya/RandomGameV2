using System;
namespace RandomGameV2
{
    using System;
    namespace ConsoleApp3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Random x = new Random();
                int n = x.Next(51);
                int c = 3;
                Console.WriteLine("Компьютер загадал число от 0 до 50.Попробуйте отгадать его за три попытки.");
                Console.WriteLine("Введите первое число.");
                int a = Convert.ToInt32(Console.ReadLine());
                while (c <= 3)
                {
                    if (a == 17)
                    {
                        Console.WriteLine("Вы угадали число.");
                        break;
                    }
                    else
                    {
                        n++;
                        if (n == 24)
                        {
                            Console.WriteLine("Вы не отгадали число...");
                            break;
                        }
                        Console.WriteLine("Нет, это не число" + a + ".Попытка № " + c + ".");
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.ReadLine();
            }


        }
    }
}
