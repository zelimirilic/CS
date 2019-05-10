using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2019, 2, 12, 8, 30, 545, new TimeSpan(1, 0, 0));
            }
            return order;
        }
        public bool Save()
        {
            return true;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            if(orderId == 10)
            {
                orderDisplay.FirstName = "Zelimir";
                orderDisplay.LastName = "Ilic";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 2, 14, 10, 00, 00, new TimeSpan(1, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Majke Jevrosime bb",
                    StreetLine2 = "selo Zuce",
                    City = "Beograd",
                    State = "Srbija",
                    PostalCode = "11000",
                    Country = "Srbija"
                };
            }
            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();
            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Tulips",
                    PurchasePrice = 12.54M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Raketa",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
    }
}
