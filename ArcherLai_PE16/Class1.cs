using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE16
{
    public class Class1
    {
        public abstract class HotDrink
        {
            public bool instant;
            public bool milk;
            private byte sugar;
            public string size;
            public Customer customer;
           
            public virtual void AddSugar(byte amount)
            {

            }

            public HotDrink(string brand)
            {

            }

        }

        public class Customer
        {

        }
    }
}
