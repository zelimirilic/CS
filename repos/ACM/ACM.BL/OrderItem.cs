using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int OrderItemId)
        {
            this.OrderItemId = OrderItemId;
        }
        public int OrderItemId { get; private set; }
        public int Productid { get; set; }
        public int OrderQuantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public bool Validate()
        {
            var isValid = true;

            if (Productid <= 0) isValid = false;
            if (OrderQuantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
    }
}
