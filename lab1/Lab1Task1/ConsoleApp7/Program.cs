﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cnt = 0;
            bool flag = false;        //flag=можно представить что сейчас каждый элемент массива держит свой флаг(false)
                                      // и если он не prime то его флаг станет true , и мы выведем те элементы массива
                                      //у которых флаг false
            for (int i = 0; i < n; i++)
            {
                flag = false;
                if (a[i] <= 1) continue;    //если элемент массива меньше или равен еднице то их не расматриваем
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) flag = true;     //если элемент массива не prime то вот тут он станет true
                if (!flag) cnt++;                    //считаем сколько у нас prime-ов
            }

            Console.WriteLine(cnt);

            for (int i = 0; i < n; i++)
            {
                flag = false;
                if (a[i] <= 1) continue;
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) flag = true;
                if (!flag) Console.Write(a[i] + " ");     //выводим все prime цифры
            }
            Console.ReadKey();
        }
    }
}
