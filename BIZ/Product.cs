using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        AddStuff ads = new AddStuff();
        public Product(string pname, int qty, decimal pri) 
        { 
            ProductName = pname;
            Quantity = qty;
            Price = pri;  
        }

        public void AddMyNewProduct()
        {
            ads.AddNewProduct(ProductName, Quantity, Price);
        }



    }
}
