using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 5
Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
его результат. Необходимо поддерживать только две операции: + и –.
*/

namespace HW_2_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string line = Console.ReadLine().Replace(" ", "");
            int res = 0;
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= '0' && line[i] <= '9')
                {
                    res = res * 10 + line[i] - '0';
                    count++;
                }
            }
            line = line.Remove(0, count);
            Console.WriteLine($"Результат: {line}");
        }
    }
}
