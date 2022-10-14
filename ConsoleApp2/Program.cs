namespace Практическая
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Выберите одну из трех программ: 1 - Угадай число, 2-Таблица Умножения, 3-Делители числа, 4-Закончить работу программы ");
                int nomber = Convert.ToInt32(Console.ReadLine());
                if (nomber == 1)
                {
                    chislo();
                }
                if (nomber == 2)
                {
                    tabl();
                }
                if (nomber == 3)
                {
                    delitel();
                }
                if (nomber == 4)
                {
                    break;
                }
            }
        }
        static void chislo()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            Console.WriteLine("Попробуйте угадать число то 0 до 100.");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != a)
            {
                 b = Convert.ToInt32(Console.ReadLine());
                if (b > a)
                {
                    Console.WriteLine("Много");
                }
                else if (b < a)
                {
                    Console.WriteLine("Мало");
                }
                else if (b == a) ;
            }
            Console.WriteLine("Вы угадали.");
        }
        static void tabl()
        {
            {
                int[,] tabl = new int[10, 10];
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        tabl[i, j] = i * j;
                        Console.Write( tabl[i, j]);
                        Console.WriteLine();
                    }
                }
            }
        }

        static void delitel()
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Делители числа:");
            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
}