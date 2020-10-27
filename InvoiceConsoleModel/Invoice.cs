using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceConsoleModel
{
    public class Invoice
    {

        public Invoice()
        {
            Items = new List<ProductItems>();
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<ProductItems> Items { get; set; }
        public decimal Total { get; set; }
    }
}
