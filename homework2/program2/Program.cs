using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("请输入整数数组的长度：");
            n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            Console.WriteLine("请依次输入数组中的元素：");
            int i;
            for(i=0;i<n;i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            //求最大值
            int max = intArray[0];
            for (i = 1; i < n; i++)
            {
                if(max<intArray[i])
                {
                    max = intArray[i];
                }
            }
            Console.WriteLine("数组中最大值为：" + max);
            //求最小值
            int min = intArray[0];
            for (i = 1; i < n; i++)
            {
                if (min > intArray[i])
                {
                    min = intArray[i];
                }
            }
            Console.WriteLine("数组中最小值为：" + min);
            //求平均值
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                sum += intArray[i];
            }
            Console.WriteLine("数组的平均值为：" + sum / n);
            //输出元素的和
            Console.WriteLine("数组中所有元素的和为：" + sum);
            Console.WriteLine("按下任意键以结束");
            Console.ReadKey();
        }
    }
}
