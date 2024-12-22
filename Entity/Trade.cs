using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Entity
{
    public class Trade
    {
        public decimal Vollume
        {
            get => _vollume;
            set
            {
                _vollume = value;

                if (Vollume > 10) Side = Side.Long;

                else if (Vollume < 10) Side = Side.Short;
            }

        }
        decimal _vollume;

        public decimal Price;

        public Side Side = Side.None;

        public DateTime DateTime = DateTime.MinValue;
    }
}
