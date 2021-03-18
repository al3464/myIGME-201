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

            public abstract void Steam();

        }
        interface IMood
        {
            void Mood(string r);
        }
        public class Customer : IMood
        {
            public string name;
            public string creditCardNumber;

            public Customer()
            {

            }

            public void Mood(string r)
            {
          
            }
        }

        public class Waiter : IMood
        {
            string name;
            public void Mood(string r)
            {

            }

            public void ServeCustomer(HotDrink cup)
            {

            }
        }

        interface ITakeOrder
        {
            void TakeOrder();
        }

        public class CupOfCoffee : ITakeOrder
        {
            public string beanType;
            public override void Steam() 
            {
                
            }

            public void TakeOrder()
            {
                
            }


        }

        public class CupOfTea : ITakeOrder
        {
            public string leafType;
            public override void Steam()
            {

            }

            public void TakeOrder()
            {

            }

            public bool customerlsWealthy;
        }

        public class CupOfCocoa : ITakeOrder
        {
           public int numCups;
            public bool marshmallows;
            private string source;
            public string Source;
            public override void Steam()
            {

            }

            public override void AddSugar(byte amount)
            {

            }

            public void TakeOrder()
            {

            }

            public bool marshmellows() : base("Expensice Organic Brand")
            {

            }

        }

        
    }
}
