using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.ViewModels
{
    public class BaseVM : INotifyPropertyChanged    // наследуем магию привязок из INotifyPropertyChanged
    {

        public void OnPropertyChanged(string prop)  // Метод создания привязки с XAML (принимает строку)
        {
            if (PropertyChanged != null)  // проверка если есть привязка Binding в коде XAML
                PropertyChanged(this, new PropertyChangedEventArgs(prop));  // передаем в WPF объект с нашим аргументом (Number), 
        }                                                                   // автоматом произойдет подписка на событие 

        //=========================================================== Events ====================================================

        public event PropertyChangedEventHandler PropertyChanged;  // событие на основе делегата PropertyChangedEventHandler

    }
}
