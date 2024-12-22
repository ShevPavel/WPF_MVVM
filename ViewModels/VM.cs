using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WPF_MVVM.ViewModels
{
    public class VM : BaseVM
    {
        public VM()
        {

        }

        //========================================================== Properties ==================================================

        public int Count
        {
            get => _number;

            set 
            {
                _number = value;
                OnPropertyChanged(nameof(Count));  // когда значение Number меняется, мы вызываем метод OnPropertyChanged и передаем ему значение Number
            }                                       // nameof добавлено чтобы работало массовое переименование
        }
        int _number;





        //=========================================================== Methods ====================================================



    }
}
