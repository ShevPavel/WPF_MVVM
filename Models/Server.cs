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

        //=========================================================== Methods ===================================================

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();

            trade.Volume = _random.Next(-10, 10);
            trade.Price = _random.Next(50000, 60000);
            trade.DateTime = DateTime.Now;

            EventTradeDelegat?.Invoke(trade);  // Если наше событие не равно null, т.е. на это событие кто-то подписался, то отправляем ему trade
            /*  
            if (EventTradeDelegat != null)   // Полная запись строчки выше
            {
                EventTradeDelegat(trade);
            }
            */
        }

        //===========================================================+ Event ===================================================

        public delegate void tradeDelegat(Trade trade);  // Создаем делегат
        public event tradeDelegat EventTradeDelegat;  // Создаем событие

    }
}
