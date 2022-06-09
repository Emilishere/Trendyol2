using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Payment
    {
        public int Id { get; set; }
        public decimal previousamount { get; set; } //onceden kartda olan mebleg-cunku mebleg normalda banklarla danisildiqdan sonra elde edilir
        public string CardType { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal afterbudget { get; set; }
        public decimal Remaining(decimal Paymentpreviousamount, decimal OrderTotalamount)
        {
            decimal afterbudget = Paymentpreviousamount - OrderTotalamount;
            return afterbudget;
        }
    }
}
