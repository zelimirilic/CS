using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.orderId = orderId;
        }
        public int orderId { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public string Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public string ShipingAdddress { get; set; }
        

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + orderId + ") ";
        }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Customer)) isValid = false;
            if (string.IsNullOrWhiteSpace(ShipingAdddress)) isValid = false;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public string Log()
        {
            var logString = this.orderId + ": " + "Date: " + this.OrderDate.Value.Date + " " + "Status: " + this.EntityState.ToString();
            return logString;
        }
    }
}
