using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //gerçek hayatta tbxProductName.Text diyerek bu verileri kullanıcdan alırız. mesela =
            // product1.ProductName = tbxProductName.Text;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            //instance creation -- örnek oluşturma
            //PascalCase     //camelCase -------------------------case sensitive büyük küçük harf duyarlıdır.
            ProductManager productManager = new ProductManager();
            //stack   tarafı              = //heap tarafı

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
