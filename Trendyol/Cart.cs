using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Cart
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public override string ToString()

        {
            return $"CartId -- {Id}".ToString();
        }

    }
}
