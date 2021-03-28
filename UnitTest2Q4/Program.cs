using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q4
{
    public interface PhoneInterface {
        void Answer();
        void MakeCall();
        void HangUp();
    
    }

    public abstract class Phone {
        private string phoneNumber;

        public string address;

        public string PhoneNumber;
        public abstract void Connect();
        public abstract void Disconnect();
    
    }


    public class PushButtonPhone : PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public virtual void Connect()
        {

        }

        public virtual void Disconnect()
        {

        }
    }


    public class RotaryPhone : PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public virtual void Connect() 
        { 
        }
        
      
        public virtual void Disconnect()
        {

        }


    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho;
        public string FemaleSideKick;
        public void TimeTravel()
        {
            
        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() 
        {

        }
        public void CloseDoor() 
        {
            

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
