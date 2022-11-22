using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_HW25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, которое нужно возвести в степень: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            int B = int.Parse(Console.ReadLine());

            int pow = 1;

            for (int i = 0; i < B; i++)
            {
                pow = pow * A;
            }
            Console.WriteLine("Ответ: " + pow);
        }
    }
}
