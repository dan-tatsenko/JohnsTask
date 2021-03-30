using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public DateTime PeriodEndDate { get; set; }
        public decimal InvoiceTotalAmount { get; set; }
    }
}
