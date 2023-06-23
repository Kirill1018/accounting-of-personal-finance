using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace accounting_of_personal_finance
{
    public class Summ_table
    {
        private string month;
        private int shift, modification, _alteration;//изменение баланса
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Alteration
        {
            get { return shift; }
            set { shift = value; }
        }
        public int Amendment
        {
            get { return modification; }
            set { modification = value; }
        }
        public int _modification
        {
            get { return _alteration; }
            set { _alteration = value; }
        }
        public int sum = 23000 + 20000 + 19000 + 24500 + 22600 + 18000 + 14000 + 15600 + 17200 + 13000 + 11000, amount = 11500 + 11800 + 10500 + 9500 + 8200 + 11600 + 9800 + 4500 - 3000 - 3500 + 6700, number = 0;//суммы
        public Summ_table(string _month, int _change, int _shift, int _amendment)
        {
            month = _month;
            shift = _change;
            modification = _shift;
            _alteration = _amendment;
        }
    }
}