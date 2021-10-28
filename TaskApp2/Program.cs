using System;

namespace TaskApp2
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin:"); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b ededini daxil edin:"); int b = Convert.ToInt32(Console.ReadLine());
            sum = Hesabla(a, b);
            Console.WriteLine($"{a} ededinden {b} ededine qeder butun ededlerin cemi ={sum} ");
        }
        public static int Hesabla(int a, int b)
        {

            if (a < b)
            {
                do
                {
                    sum += a;
                    a++;
                } while (a <= b);
            }
            else
            {
                Console.WriteLine("a ededi b ededinden kicik olmalidir!");
            }
            return sum;
        }
    }
}
