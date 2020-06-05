using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string num = Convert.ToString(number);
            Console.WriteLine("Длинна числа - " + num.Length);
        }
        static void Authorise()
        {
            Console.WriteLine("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}", name);
            Console.ReadKey();
        }

        static void Swith()
        {
            Console.WriteLine("Введите два числа");
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            int fir = Convert.ToInt32(one);
            int sec = Convert.ToInt32(two);
            int help = 0;
            Console.WriteLine("Ваши числа - {0} и {1}", fir, sec);
            Console.ReadKey();
            Console.WriteLine("Обмен...");
            help = fir;
            fir = sec;
            sec = help;
            Console.WriteLine("fir = {0}, sec = {1}", fir, sec);
            Console.ReadKey();
        }
    }
}
