using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Вводите символы: ");
            char input; int spaceCount = 0;
            do {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            } while (input != '.');
            Console.WriteLine("Пробелы: " + spaceCount);
            
            ///////
            
            Console.Write("Введите номер билета:  ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6) {
                int ab = 0;
                int bc = 0;
                for (int i = 0; i < ch.Length; i++) {
                    if (i < 3) {
                        ab += ticketNumber[i];
                    }
                    else bc += ticketNumber[i];
                }
                if (ab == bc) {
                    Console.WriteLine("Счастливый билет: {0} = {1}", ab, bc);
                }
                else Console.WriteLine("Не счастливый билет: {0} != {1}", ab, bc);
            }
            else Console.WriteLine("Число не правильно!");
           
            ////////
            
            Console.Write("Введите первое число:  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (a <= b) {
                for (int i = 0; i < a; i++)
                Console.Write("{0} ", a);
                Console.WriteLine();
                a++;
            }
            
            //////

            //string s = Console.ReadLine(); ;
            //Console.WriteLine(s[2] + "" + s[1] + "" + s[0]);

            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            int reverse_val = int.Parse(new string(value.ToString().Reverse().ToArray()));
            Console.Write("Обратное число: " + reverse_val + "\n");
        }
    }
}
