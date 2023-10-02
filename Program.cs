using System;
using System.Linq.Expressions;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace a_thing
{
    internal class Program
    {
        static void tablu()
        {
            int[,] tabll = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tabll[i, j] = i * j;
                    Console.Write("\t" + tabll[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
        static void Test(string s)
        {
            if (s == null || s == string.Empty)
            {
                Console.WriteLine("you should have written SOMETHING \n");
            }
        }

        static void dell(int number)
        {
            Console.WriteLine("\n Делители числа: \n");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");
        }
        static bool Gueesthenum(int rannum)
        {
            Console.WriteLine("Введите число для сравнения с числом, выбранным коммпьютером\n");
            string guess = Console.ReadLine();
            Test(guess);
            int ig = Convert.ToInt32(guess);

            if (ig < rannum)
            {
                Console.WriteLine("Выбранное компьютером число больше вашего, попытайтесь угадать еще раз\n");
                return true;
            }
            else if (ig > rannum)
            {
                Console.WriteLine("Выбранное компьютером число меньше вашего, попытайтесь угадать еще раз \n");
                return true;
            }
            else
            {
                Console.WriteLine("Поздравляю! вы выиграли! Возвращаю вас в меню \n\n");
                return false;
            }
        }

        static void Main()
        {


            bool ShowMenu = true;
            while (ShowMenu)
            {
                ShowMenu = MainMenu();
            }

        }
        static bool MainMenu()
        {
            Console.WriteLine("Выберите программу \n");
            Console.WriteLine("1. Угадай число");  //clear
            Console.WriteLine("2. Таблица умножения"); //clear
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы"); //clear
            Console.WriteLine("Введите цифровое значение операции для ее инициации:");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Random rnd = new Random(101);
                        int random = rnd.Next(101);

                        bool ShowGuess = true;
                        while (ShowGuess)
                        {
                            ShowGuess = Gueesthenum(random);
                        }
                    }
                    return true;

                case "2":
                    tablu();
                    return true;
                case "3":
                    Console.WriteLine("Введите число");
                    string snum = Console.ReadLine();
                    Test(snum);
                    int num = Convert.ToInt32(snum);
                    dell(num);
                    Console.WriteLine("Хотите найти все делители еще одного числа? д/н");
                    Console.WriteLine("Выбор н вернет вас в меню.");
                    string schoice = Console.ReadLine();
                    Test(schoice);
                    if (schoice == "д")
                    {
                        Console.WriteLine("\nВведите число: ");
                        string snum2 = Console.ReadLine();
                        Test(snum2);
                        int num2 = Convert.ToInt32(snum2);
                        dell(num2);
                    }
                    else
                    {
                        Console.WriteLine("Возвращаю в меню. \n");
                    }

                    return true;
                case "4":
                    return false;
                default:
                    Console.WriteLine("Выберите одну из существующих операций. \n");
                    return true;
            }
        }
    }
}