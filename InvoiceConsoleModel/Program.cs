using System;
using System.Linq;

namespace InvoiceConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var invoice = new Invoice();
            
            invoice.CreationDate = DateTime.Now;
            invoice.Id = 9001;
            var product = new Product();
            product.ProductId = 2;
            product.Name = "Lata de coca cola";
            product.Cost = 9;
            product.Description = "Lata de coca cola 355 ml";

            var product2 = new Product();
            product2.ProductId = 3;
            product2.Name = "Lata de pepsi";
            product2.Cost = 8;
            product2.Description = "Lata de pepsi 355 ml";

            invoice.Items.Add(
                new ProductItems
                {
                    Id = 1,
                    Price = product.Cost * 1.16m,
                    ProductID = product.ProductId,
                    Product = product,
                    Quantity = 4,

                });

            invoice.Items.Add(new ProductItems
            {
                Id = 2,
                Price = product2.Cost * 1.16m,
                ProductID = product2.ProductId,
                Product = product2,
                Quantity = 2,

            });

            invoice.Total = invoice.Items.Sum(s => s.Quantity * s.Price);

            var filteredItems = invoice.Items.Where(w => w.Price > 8).ToList();

            var firstProductInList = filteredItems.FirstOrDefault().Product.Name;

            var filteredItemsSelectFields = filteredItems.Select(s => new 
            {
                Precio = s.Price,
                Costo = s.Product.Cost,  
                Nombre = s.Product.Name
            }).ToList();
            //select Price as Precio, Cost as Costo, Product.Name as Nombre from Invoice
            // where Invocie.Items.Price > 8 

        }
    }
}
