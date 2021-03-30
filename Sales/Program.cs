using System;
using System.Collections.Generic;

namespace Sales
{
    class Program
    {
        public static List<Invoice> DoInvoicing(List<Customer> customers, List<Widget> widgets,
                                        List<Sale> sales, DateTime periodStartDate, DateTime periodEndDate)
        {
            List<Invoice> Invoices = new List<Invoice>();
            int InvoiceId = 0;
            List<Sale> PeriodSales = new List<Sale>();

            PeriodSales = sales.FindAll(s => (s.SaleDate >= periodStartDate && s.SaleDate >= periodStartDate));


            foreach (Sale ps in PeriodSales)
            {
                decimal Amount = ps.Quantity * widgets.Find(w => w.Id == ps.WidgetId).SalePrice;
                int CustIndex = Invoices.FindIndex(i => i.CustomerId == ps.CustomerId);

                if (CustIndex >= 0)
                {//Existing customer
                    Invoices[CustIndex].InvoiceTotalAmount += Amount;
                }
                else
                {//New customer
                    InvoiceId++;
                    Invoice NewInvoice = new Invoice();
                    NewInvoice.Id = InvoiceId;
                    NewInvoice.CustomerId = ps.CustomerId;
                    NewInvoice.PeriodStartDate = periodStartDate;
                    NewInvoice.PeriodEndDate = periodEndDate;
                    NewInvoice.InvoiceTotalAmount = Amount;

                    Invoices.Add(NewInvoice);
                }
            }
             return Invoices;
        }
        static void Main(string[] args)
        {
            List<Invoice> Invoices = new List<Invoice>();

            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer { Id = 0, Name = "Agility CIS" });
            Customers.Add(new Customer { Id = 1, Name = "Dan Tatsenko" });
            Customers.Add(new Customer { Id = 2, Name = "John Bird" });
            Customers.Add(new Customer { Id = 3, Name = "Laura Steffensen" });

            List<Widget> Widgets = new List<Widget>();
            Widgets.Add(new Widget { Id = 0, Name = "iPhoneX", SalePrice = 1700 });
            Widgets.Add(new Widget { Id = 1, Name = "Huawei nova3", SalePrice = 450 });
            Widgets.Add(new Widget { Id = 2, Name = "Yellow Sofa Level9", SalePrice = 1000 });
            Widgets.Add(new Widget { Id = 3, Name = "Coffee Machine", SalePrice = 900 });

            List<Sale> Sales = new List<Sale>();
            Sales.Add(new Sale { Id = 0, CustomerId = 0, WidgetId = 2, Quantity = 1, SaleDate = DateTime.Parse("2021-03-30") });
            Sales.Add(new Sale { Id = 1, CustomerId = 1, WidgetId = 1, Quantity = 1, SaleDate = DateTime.Parse("2020-12-26") });
            Sales.Add(new Sale { Id = 2, CustomerId = 3, WidgetId = 0, Quantity = 2, SaleDate = DateTime.Parse("2021-01-05") });
            Sales.Add(new Sale { Id = 3, CustomerId = 1, WidgetId = 2, Quantity = 3, SaleDate = DateTime.Parse("2021-02-28") });
            Sales.Add(new Sale { Id = 4, CustomerId = 1, WidgetId = 2, Quantity = 1, SaleDate = DateTime.Parse("2021-02-20") });
            Sales.Add(new Sale { Id = 5, CustomerId = 3, WidgetId = 2, Quantity = 4, SaleDate = DateTime.Parse("2021-03-12") });
            Sales.Add(new Sale { Id = 6, CustomerId = 3, WidgetId = 3, Quantity = 1, SaleDate = DateTime.Parse("2021-03-30") });
            Sales.Add(new Sale { Id = 7, CustomerId = 3, WidgetId = 0, Quantity = 1, SaleDate = DateTime.Parse("2021-03-15") });
            Sales.Add(new Sale { Id = 8, CustomerId = 3, WidgetId = 1, Quantity = 4, SaleDate = DateTime.Parse("2019-03-30") });
            Sales.Add(new Sale { Id = 9, CustomerId = 0, WidgetId = 3, Quantity = 1, SaleDate = DateTime.Parse("2021-03-30") });
            Invoices = DoInvoicing(Customers, Widgets, Sales, DateTime.Parse("2021-01-01"), DateTime.Parse("2021-03-31"));

            foreach (Invoice inv in Invoices)
            {
                Console.WriteLine($"Id = {inv.Id}\tCustomerId = {Customers.Find(c => c.Id == inv.CustomerId).Name}\tPeriod: {inv.PeriodStartDate.ToShortDateString()} - {inv.PeriodEndDate.ToShortDateString()}\tTotal Sum = {inv.InvoiceTotalAmount}");
            }
        }
    }
}
