using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE12Q3
{
    public class Myclass
    {
        private string myString;
        
        
        public string thisString
        {
            set
            {
                thisString = value;
            }
        }

        public virtual string getString()
        {
            return myString;
        }
        class MyDerivedClass : Myclass
        {
            public override string getString() 
            {
                string text = "output from the derived class";
                return base.getString() + text;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
