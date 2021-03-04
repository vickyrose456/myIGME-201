using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    // {type:class}
    // {generate:true}
    // {direction:topDown}

    //[+A:Vehicle||+LoadPassenger():v;]

    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {
            
        }
    }



    //[+A:Car||]
    //[+A:Train||]

    //[+I:IPassengerCarrier||LoadPassenger()]
    //[+I:IHeavyLoadCarrier||]

    //[+Compact||]
    //[+SUV||]
    //[+Pickup||]
    //[+PassengerTrain||]
    //[+FreightTrain||]
    //[+424DoubleBogey||]

    //[+A:Vehicle]<-[+A:Car]
    //car to car type
    //[+A:Car]<-[+Compact]
    //[+A:Car]<-[+SUV]
    //[+A:Car]<-[+Pickup]

    //[+A:Vehicle]<-[+A:Train]
    //train to train type
    //[+A:Train]<-[+PassengerTrain]
    //[+A:Train]<-[+FreightTrain]
    //[+A:Train]<-[+424DoubleBogey]

    //connects to passenger
    //[+I:IPassengerCarrier]^[+Compact]
    //[+I:IPassengerCarrier]^[+SUV]
    //[+I:IPassengerCarrier]^[+Pickup]
    //[+I:IPassengerCarrier]^[+PassengerTrain]

    //connects to heavy loader
    //[+I:IHeavyLoadCarrier]^[+Pickup]
    //[+I:IHeavyLoadCarrier]^[+FreightTrain]
    //[+I:IHeavyLoadCarrier]^[+424DoubleBogey]



    public class Class1
    {

    }
}
