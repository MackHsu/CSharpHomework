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
            Console.WriteLine("请输入两个数字以求乘积：");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            double result = a * b;
            Console.WriteLine(a + "和" + b + "的乘积为：" + result);
            Console.WriteLine("按下任意键结束");
            Console.ReadKey();
        }
    }
}
