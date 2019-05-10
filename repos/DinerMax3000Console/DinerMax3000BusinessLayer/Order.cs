using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console.Business
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculateTotal = 0;
                foreach (MenuItem item in items)
                {
                    calculateTotal += item.Price;
                }
                return calculateTotal;
            }
        }
    }
}
