using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Entity
{
    public class Trade
    {
        public decimal Vollume;

        public decimal Price;

        public Side Side;

        public DateTime DateTime = DateTime.MinValue;
    }
}
