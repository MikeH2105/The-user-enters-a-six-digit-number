/*Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре-
буется вывести сообщение об ошибке.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Доброго дня!\nВведіть будь-ласка шестизначне число:");
            string num = Console.ReadLine();
            int a1, a2, a3, a4, a5, a6;
            int sixNum = Convert.ToInt32(num);

            if (sixNum > 99999 || sixNum < 1000000)
            {
                a6 = sixNum % 10;
                sixNum = sixNum / 10;
                a5 = sixNum % 10;
                sixNum = sixNum / 10;
                a4 = sixNum % 10;
                sixNum = sixNum / 10;
                a3 = sixNum % 10;
                sixNum = sixNum / 10;
                a2 = sixNum % 10;
                sixNum = sixNum / 10;
                a1 = sixNum % 10;
                sixNum = sixNum / 10;

                int[] arr= {a1,a2,a3,a4,a5,a6};
                int[] arr2 = new int[6];

                Console.WriteLine("Введіть перше число для заміни");
                string change1 = Console.ReadLine();
                Console.WriteLine("Введіть друге число для заміни");
                string change2 = Console.ReadLine();
                int ch1 = Convert.ToInt32(change1);
                int ch2 = Convert.ToInt32(change2);
                ch1--;
                ch2--;
                for (int i = 0; i < 6; i++)
                {
                    if(i!=ch1 && i != ch2)
                    {
                            arr2[i] = arr[i]; 
                    }
                    else if (i==ch1)
                    {
                        arr2[i] = arr[ch2];
                    }
                    else if (i == ch2)
                    {
                        arr2[i] = arr[ch1];
                    }
                }
                String b1 = Convert.ToString(arr2[0]);
                String b2 = Convert.ToString(arr2[1]);
                String b3 = Convert.ToString(arr2[2]);
                String b4 = Convert.ToString(arr2[3]);
                String b5 = Convert.ToString(arr2[4]);
                String b6 = Convert.ToString(arr2[5]);
                String b7 = b1 + b2 + b3 + b4 + b5 + b6;
                int finall = Convert.ToInt32(b7);
                Console.WriteLine(finall);


                Console.WriteLine("Дякуємо!!!");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Ви ввели неправильне значення!");
            }

            


        }
    }
}
