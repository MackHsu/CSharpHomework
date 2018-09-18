using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[101]; //isPrime[i]为true表示i是素数，否则表示i不是素数
            int i;
            for (i = 2; i < 101; i++)
            {
                isPrime[i] = true;
            }
            int j;
            //去掉i的整数倍
            for (i = 2; i < 101; i++)
            {
                for (j = 2; i * j <= 100; j++) //j是倍数
                {
                    isPrime[i * j] = false;
                }
            }
            Console.WriteLine("2~100以内的素数有：");
            //循环输出isPrime为true的值
            for (i = 2; i < 101; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\n按下任意键以结束");
            Console.ReadKey();
        }
    }
}
