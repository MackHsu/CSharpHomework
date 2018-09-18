using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数以求出其所有素数因子：");
            int a, i, j;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("该整数的所有素数因子为：");
            //循环判断i是否为a的素数因子
            for(i = 2; i <= a; i++)
            {
                if(a % i == 0)//判断i是否是a的因子
                {
                    //判断i是否是素数
                   for(j=2;j<=i;j++)
                    {
                        if(j==i)
                        {
                            Console.Write(i+"\t");
                            break;
                        }
                        else if(i%j==0)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\n按下任意键以结束");
            Console.ReadKey();
        }
    }
}
