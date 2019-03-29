using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Note : Storable
    {
        public string Read()
        {
            return "Reading note from disk";
        }

        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to disk...");
        }
        private ReturnStatus status;
        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}