using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
    class Order
    {
        public Order():this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            orderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        /// <summary>
        /// Dateimeoffset good for different timezones, eastern, pacific 
        /// </summary>
        public  DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public List<OrderItem> orderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;

        }
        public Order Retrieve(int orderId)
        {
            return new Order();

        }

        public bool Save()
        {
            return true;

        }
    }
}
