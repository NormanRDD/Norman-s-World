using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\milkyway3\yyyy\1111\rrrr.txt";
            string path2 = @"C:\Users\User\Desktop\milkyway3\wwww\qqqq\tttt.txt";

            if (File.Exists(path2))
            //Проверяем есть ли существующий файл 
            //Exists(file): определяет, существует ли файл
            {
                File.Delete(path2);     //Если есть ,то удаляем.
                File.Move(path, path2);    //После файл с path перемещяем в path2
            }
        }
    }
}
