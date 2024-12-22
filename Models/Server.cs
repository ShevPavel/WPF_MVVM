using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using WPF_MVVM.Entity;

namespace WPF_MVVM.Models
{
    public class Server
    {
        public Server()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        //=========================================================== Fields ====================================================

        Random _random = new Random();

        //=========================================================== Methods ====================================================

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Trade 

            Count = _random.Next(0, 100);
        }
    }
}
