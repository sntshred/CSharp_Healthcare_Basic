using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
   public class ProductRepositiory
    {
      public Product Retrieve(int productid)
        {
            Product product = new Product(productid);

            if (productid == 2)
            {
                product.ProductName = "Mobile";
                product.CurrentPrice = 200;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }

            }
            return success;
        }
    }
}
