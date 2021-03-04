using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    //[+A:Vehicle||+LoadPassenger():v;]

    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }//loadPass

    }//end vehicle abstract class

    //[+I:IPassengerCarrier||LoadPassenger()]
    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }//passCarrier

     //[+I:IHeavyLoadCarrier||]
    public interface IHeavyLoadCarrier
    {

    }//loadCarrier

    //[+A:Car||]
    //[+A:Vehicle]<-[+A:Car]
    public abstract class Car : Vehicle
    {

    }//car

    //[+A:Train||]
    //[+A:Vehicle]<-[+A:Train]
    public abstract class Train : Vehicle
    {

    }//train

    //[+Compact||]
    //[+I:IPassengerCarrier]^[+Compact]
    //[+A:Car]<-[+Compact]
    public class Compact : Car, IPassengerCarrier
    {
        
    }//end compact

    //[+SUV||]
    //[+A:Car]<-[+SUV]
    //[+I:IPassengerCarrier]^[+SUV]
    public class SUV : Car, IPassengerCarrier
    {
        
    }//end SUV

    //[+Pickup||]
    //[+A:Car]<-[+Pickup]
    //[+I:IPassengerCarrier]^[+Pickup]
    //[+I:IHeavyLoadCarrier]^[+Pickup]
    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
        
    }//end pickup

    //[+PassengerTrain||]
    //[+A:Train]<-[+PassengerTrain]
    //[+I:IPassengerCarrier]^[+PassengerTrain]
    public class PassengerTrain : Train, IPassengerCarrier
    {
        
    }//end passTrain

    //[+FreightTrain||]
    //[+A:Train]<-[+FreightTrain]
    //[+I:IHeavyLoadCarrier]^[+FreightTrain]
    public class FreightTrain : Train, IHeavyLoadCarrier
    {
        
    }//freightTrain

    //[+424DoubleBogey||]
    //[+A:Train]<-[+424DoubleBogey]    
    //[+I:IHeavyLoadCarrier]^[+424DoubleBogey]
    public class DoubleBogey : Train, IHeavyLoadCarrier
    {
        
    }//424DoubleBogey


    public class Class1
    {

    }
}
