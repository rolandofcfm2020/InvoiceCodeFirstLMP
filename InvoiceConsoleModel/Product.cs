using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceConsoleModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int? ColorId { get; set; }
    }
}
