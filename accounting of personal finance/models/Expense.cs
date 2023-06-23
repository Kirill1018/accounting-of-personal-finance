using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accounting_of_personal_finance
{
    public class Expense
    {
        private DateTime date;
        private int bal_chang;
        private string reason;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Changing
        {
            get { return bal_chang; }
            set { bal_chang = value; }
        }
        public string Cause
        {
            get { return reason; }
            set { reason = value; }
        }
        public Expense(DateTime _date, int change, string why)
        {
            date = _date;
            bal_chang = change;
            reason = why;
        }
    }
}