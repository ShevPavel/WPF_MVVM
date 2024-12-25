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
            _server = new Server();   // Внутри ViewModel создаем объект Model (в нашем случае server - коннектор к бирже)
            _server.EventTradeDelegat += _server_EventTradeDelegat;  // Подписываемся на события внутри модели (Model)
        }

        //========================================================== Fields ======================================================

        Server _server;

        //========================================================== Properties ==================================================

        public decimal Volume  // привязки работают только со свойствами
        {
            get => _volume;

            set 
            {
                _volume = value;
                OnPropertyChanged(nameof(Volume));  // когда значение Volume меняется, мы вызываем метод OnPropertyChanged и передаем ему значение Volume
            }                                       // nameof добавлено чтобы работало массовое переименование
        }
        decimal _volume;

        public decimal Summ
        {
            get => _summ;

            set
            {
                _summ = value;
                OnPropertyChanged(nameof(Summ));  // Метод который извещает об изменении свойства
            }
        }
        decimal _summ;

        public decimal Price
        {
            get => _price;

            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));  // Метод который извещает об изменении свойства
            }                                       
        }
        decimal _price;

        public DateTime DateTimeTrade
        {
            get => _dateTimeTrade;

            set
            {
                _dateTimeTrade = value;
                OnPropertyChanged(nameof(DateTimeTrade));   // Метод который извещает об изменении свойства
            }
        }
        DateTime _dateTimeTrade;

        //=========================================================== Methods ====================================================

        private void _server_EventTradeDelegat(Trade trade)  // метод вызывается после срабатывания таймера (Timer_Elapsed)
        {
            Volume = trade.Volume;
            Price = trade.Price;
            DateTimeTrade = trade.DateTime;
            Summ += Volume;
        }

    }
}
