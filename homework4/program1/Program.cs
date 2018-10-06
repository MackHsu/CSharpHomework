using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class AlarmClockEventArgs:EventArgs
    {
        public int Hour { get; set; }               //设定的闹钟时间
        public int Minute { get; set; }             //设定的闹钟时间
        public int CurrentHour { get; set; }        //当前时间
        public int CurrentMinute { get; set; }      //当前时间
        public bool IsTime { get; set; }            //设定的闹钟时间是否等于当前的时间
    }

    public delegate void AlarmClockEventHandler(object sender, AlarmClockEventArgs e);

    public class AlarmClock
    {
        public event AlarmClockEventHandler RunAlarmClock;          //获取当前时间、比较设定的闹钟时间是否等于当前时间

        public void SetAlarmClock(int h, int m)
        {
            AlarmClockEventArgs time = new AlarmClockEventArgs();
            time.Hour = h;
            time.Minute = m;
            time.IsTime = false;
            while (true)
            {
                RunAlarmClock(this, time);
                if (time.IsTime) break;
                System.Threading.Thread.Sleep(1000); //每秒更新一次时间
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            clock.RunAlarmClock += GetTime;
            clock.RunAlarmClock += CompareTime;

            int h, m;
            Console.WriteLine("请依次输入设定闹钟的时和分（不输入则默认为当前时间）：");
            Console.Write("时：");
            try
            {
                h = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException)    //若输入字符串为空则把当前时间赋给h
            {
                h = Int32.Parse(DateTime.Now.Hour.ToString());
            }
            Console.Write("分：");
            try
            {
                m = Int32.Parse(Console.ReadLine());
            }
            catch(System.FormatException)   //若输入字符串为空则把当前时间赋给m
            {
                m = Int32.Parse(DateTime.Now.Minute.ToString());
            }
            Console.WriteLine($"已成功设定闹钟时间为 {h}:{m}");
            clock.SetAlarmClock(h, m);

            Console.WriteLine("时间到！");
            Console.ReadKey();
        }

        static void GetTime(object sender, AlarmClockEventArgs e)           //获取当前的时间
        {
            e.CurrentHour = Int32.Parse(DateTime.Now.Hour.ToString());
            e.CurrentMinute = Int32.Parse(DateTime.Now.Minute.ToString());
        }

        static void CompareTime(object sender, AlarmClockEventArgs e)       //比较时间
        {
            if (e.Hour == e.CurrentHour && e.Minute == e.CurrentMinute) e.IsTime = true;
        }
    }
}
