﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_UnitTestQ4
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumer
        {
            get;
            set;
        }

        public abstract void Connect();
        public abstract void Disconnect();
    }//end phone

    public interface IPhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }//end phone interface

    public class RotaryPhone : Phone, IPhoneInterface
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
        public override void Connect()
        {
      
        }
        public override void Disconnect()
        {

        }
    }//end rotary phone

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get;
        }

        public string FemaleSideKick
        {
            get;
        }

        public void TimeTravel()
        {
        }

        //overload bool operators ==, !=, <, >, <= and >= for Tardis
        //whichDrWho compares to Tardis objects
        
        public static bool operator ==(Tardis myTardis1, Tardis myTardis2)
        {
            return (myTardis1.whichDrWho == myTardis2.whichDrWho);
        }

        public static bool operator !=(Tardis myTardis1, Tardis myTardis2)
        {
            return !(myTardis1.whichDrWho == myTardis2.whichDrWho);
        }

        public static bool operator <(Tardis myTardis1, Tardis myTardis2)
        {
            return !(myTardis1.whichDrWho >= myTardis2.whichDrWho);
        }

        public static bool operator >(Tardis myTardis1, Tardis myTardis2)
        {
            return !(myTardis1.whichDrWho <= myTardis2.whichDrWho);
        }

        public static bool operator >=(Tardis myTardis1, Tardis myTardis2)
        {
            return (myTardis1.whichDrWho >= myTardis2.whichDrWho);
        }

        public static bool operator <=(Tardis myTardis1, Tardis myTardis2)
        {
            return (myTardis1.whichDrWho <= myTardis2.whichDrWho);
        }


    }//end tardis



    public class PushButtonPhone : Phone, IPhoneInterface
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
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }//push button phone

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
    }


}
