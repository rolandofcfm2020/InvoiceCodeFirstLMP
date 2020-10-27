using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceConsoleModel
{
    public class ProductItems
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
    }
}
