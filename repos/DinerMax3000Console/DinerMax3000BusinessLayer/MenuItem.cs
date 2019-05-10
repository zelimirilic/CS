using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console.Business
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("Less or equal 0 is wrong value !");
                }
            }
        }

        internal void Add(MenuItem item)
        {

        }
    }
}
