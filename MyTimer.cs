using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsReadGhana
{
    static class MyTimer
    {
        public static void stopTimer(System.Windows.Forms.Timer t)
        {
            t.Stop();
        }

        public static void startTimer(System.Windows.Forms.Timer t)
        {
            t.Start();
        }

        public static void setInterval(System.Windows.Forms.Timer t, difficulty d)
        {
            switch (d)
            {
                case difficulty.Easy:
                    t.Interval = 20000; // 1 tick every 20 seconds
                    break;
                case difficulty.Normal:
                    t.Interval = 15000; // 1 tick every 15 seconds
                    break;
                case difficulty.Intermediate:
                    t.Interval = 12000; // 1 tick every 12 seconds 
                    break;
                case difficulty.Hard:
                    t.Interval = 8000; // 1 tick every 8 seconds
                    break;
            }
        }

    }
}
