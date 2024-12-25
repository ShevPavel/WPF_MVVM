using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WPF_MVVM.Models;
using WPF_MVVM.Entity;

namespace WPF_MVVM.ViewModels
{
    public class VM : BaseVM
    {
        public VM()
        {
            _server = new Server();
            _server.EventTradeDelegat += _server_EventTradeDelegat;
        }



        //========================================================== Fields ======================================================

        Server _server;


        //========================================================== Properties ==================================================

        public decimal Volume
        {
            get => _volume;

            set 
            {
                _volume = value;
                OnPropertyChanged(nameof(Volume));  // когда значение Number меняется, мы вызываем метод OnPropertyChanged и передаем ему значение Number
            }                                       // nameof добавлено чтобы работало массовое переименование
        }
        decimal _volume;

        public decimal Price
        {
            get => _price;

            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price)); 
            }                                       
        }
        decimal _price;

        public DateTime DateTimeTrade
        {
            get => _dateTimeTrade;

            set
            {
                _dateTimeTrade = value;
                OnPropertyChanged(nameof(DateTimeTrade));
            }
        }
        DateTime _dateTimeTrade;

        //=========================================================== Methods ====================================================

        private void _server_EventTradeDelegat(Trade trade)  // метод вызывается после срабатывания таймера (Timer_Elapsed)
        {
            Volume = trade.Volume;
            Price = trade.Price;
            DateTimeTrade = trade.DateTime;
        }

    }
}
