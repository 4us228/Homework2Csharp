using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Выполнил Цубера Кристиан
/// </summary>

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(lowNumber(10, 7, 11));//Вызов метода для задания 1
            Console.ReadLine();
            Console.WriteLine(countNumber(4565));//Вызов метода для задания 2
            Console.ReadLine();
            oddSum();//Вызов метода для задания 3
            authorization();//Вызов метода для задания 4
            index();//Вызов метода для задания 5



        }

        #region Задание 1 
        static int lowNumber(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            if (b < a && b < c) return b;
            return c;
        }
        #endregion
        #region Задание 2
        static int countNumber(int x)
        {
            string number = x.ToString();
            return number.Length;
        }
        #endregion
        #region Задание 4
        static Boolean checkLogin(string login, string password)
        {
            string log = "root";
            string pass = "GeekBrains";
            if (login.Equals(log) && password.Equals(pass)) return true;
            return false;

        }
        #endregion
        #region Задание 5 (Метод получился немного перегружен но было лень переделывать)
        static void index()
        {
            Console.ReadLine();
            double weight, hight, changeWeight = 0;
            Console.WriteLine("Введите ваш рост в см");

            hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Отлично, теперь введите ваш вес");

            weight = int.Parse(Console.ReadLine());
            double index = weight / (hight * 2 / 100);
            double indexWeight = weight / index;

            Console.WriteLine("Твой индекс массы тела = ");
            Console.Write(" {0:F2} ", index);

            if (index < 18.5)
            {
                changeWeight = indexWeight * (18.5 - index);
                Console.WriteLine($" вам нужно набрать {changeWeight} кг");
            }

            if (index > 24.9)
            {
                changeWeight = indexWeight * (index - 24.9);
                Console.WriteLine($" вам нужно сбросить {changeWeight} кг");
            }
            if (index > 18.5 && index < 24.9) Console.WriteLine("Твой вес в норме");

            Console.ReadLine();
        }
        #endregion
        #region Авторизация
        static void authorization()
        {
            string enterlog, enterpass;
            int count = 3;
            do
            {
                Console.WriteLine("Для авторизации введите ваш логин");
                enterlog = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                enterpass = Console.ReadLine();
                if (checkLogin(enterlog, enterpass))
                {
                    Console.WriteLine("Доступ разрешен");
                    break;
                }
                else count--;
                Console.WriteLine("У вас осталось " + count + " попыток");
            } while (count > 0);
            Console.ReadLine();




        }
        #endregion
        #region Задание 3
        static void oddSum()
        {
            Console.WriteLine("Введите число или введите 0 чтобы узнать сумму нечетных чисел:");
            int sum = 0;
            int enterNumber;
            do
            {
                enterNumber = int.Parse(Console.ReadLine());
                if (enterNumber % 2 != 0 && enterNumber > 0) sum += enterNumber;
            } while (enterNumber != 0); Console.WriteLine("Сумма чисел = " + sum);
            Console.ReadLine();
        }
        #endregion
    }
}

