using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olivieri_UnitTestQ4;

namespace Question6UnitTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create new tardis object
            Tardis tardis = new Tardis();

            //new photobooth object
            PhoneBooth phoneBooth = new PhoneBooth();

            //pass each to a UsePhone(object obj) method 
            UsePhone(tardis);
            UsePhone(phoneBooth);
        }
        static void UsePhone(object obj)
        {
            Phone phone = (Phone)obj;
            IPhoneInterface iphoneInterface = null;
                
            phone.MakeCall();
            phone.HangUp();



            if (phone.GetType() == typeof(Tardis))
            {
                iphoneInterface = (IPhoneInterface)phone;
                phone.TimeTravel();
            }
            if (phone.GetType() == typeof(PhoneBooth))
            {
                iphoneInterface = (IPhoneInterface)phone;
                phone.OpenDoor();
            }


            
            
        }
    }
}
