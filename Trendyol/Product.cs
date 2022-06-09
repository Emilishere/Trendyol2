using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    public class Product
    {
        public int Id { get; set; }
        public string title { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; } //meiset, paltar, erzaq ve s.
        public string Description { get; set; }
        public string Items { get; set; } //uzerinde pulsuz ne verilir ve ya oz hissesi hansilardi (meselen plansetlerde qelem verile biler)
        public void edit_Description(string new_Description)
        {
        }
        public override string ToString()

        {
            return $"Id -- {Id} + title -- {title} + Price -- {Price} + Type -- {Type} + Description --{Description} + Items on your product {this.Items}".ToString();
        }
    }
}
