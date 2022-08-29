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
            List<int> numbers = new List<int> { };
            List<char> operations = new List<char> { };
            if (line[0] == '-')
            {
                numbers.Add(0);
            }
            int num = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= '0' && line[i] <= '9')
                {
                    while (i < line.Length && line[i] >= '0' && line[i] <= '9')
                    {
                        num = num * 10 + int.Parse(line[i].ToString());
                        i++;
                    }
                    numbers.Add(num);
                    num = 0;
                    i--;
                }
                else if (line[i] == '+' || line[i] == '-')
                {
                    operations.Add(line[i]);
                }
            }
            int result = 0;
            bool flag = false;
            while (operations.Count != 0)
            {
                int n1 = numbers[0];
                char op = operations[0];
                if (op == '+' && flag == true)
                {
                    result += n1;
                }
                else if (op == '-' && flag == true)
                {
                    result -= n1;
                }
                if (!flag)
                {
                    result += numbers[0];
                }
                if (operations.Count != 0)
                {
                    if (flag)
                    {
                        operations.RemoveAt(0);
                    }
                    numbers.RemoveAt(0);
                    flag = true;
                }
            }
            
            Console.WriteLine($"{line} = {result}");
        }
    }
}
