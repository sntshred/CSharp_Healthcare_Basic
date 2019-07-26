using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
   public class Product:EntityBaseClass
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;

        }

        public int ProductId { get; private set; }

        private string _productName;

        public string ProductName
        {
            get {
                 
                return _productName.InsertSpaces();

            }

            set { _productName = value; }
        }
         
        public string  Description { get; set; }

        public decimal? CurrentPrice{ get; set; }

        public override bool Validate() {

            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;

            }
             if (CurrentPrice == null)
            {
                isValid = false;

            }
            return isValid;

        }
        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //}
            
        //public bool Save()
        //{
        //    return true;
        //}

    }
}
