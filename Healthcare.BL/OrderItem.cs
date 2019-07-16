﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
  public  class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProdcutId{ get; set; }

        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        public bool Validate()
        {
            var isValid = false;

            if (Quantity <= 0) isValid = false;
            if (ProdcutId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;

            return isValid;
        }
        public OrderItem Retrieve (int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }
    }




}
 