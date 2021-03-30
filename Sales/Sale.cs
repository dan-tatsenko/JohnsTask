using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int WidgetId { get; set; }
        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
    }
}
