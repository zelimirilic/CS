using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //Object myObj = new Object();

            //Console.WriteLine("Object: " + myObj.ToString());
            //Console.WriteLine("Product: " + product.ToString());

            if (productId == 2)
            {
                product.ProductName = "Tulips";
                product.ProductDescription = "Made in Netherland";
                product.CurrentPrice = 11.23M;
            }
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges && product.IsValid)
            {
                if(product.IsNew)
                {
                    //We call insert stored procedure
                }
                else
                {
                    //We call update stored procedure
                }
            }
            return success;
        }
    }
}
