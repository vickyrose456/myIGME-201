using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    // Class Program
    // Author: Victoria Olivieri
    // Purpose: PE11 - Referencing Vehicles to addPassengerCarrier
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            //initialize passsenger carrier object
            //Vehicle vehicle = null;
            IPassengerCarrier iPassCarrier = null;
            
            //call addPassenger fns
            AddPassenger(iPassCarrier);
        }
    
    // Method: addPassenger
    // Purpose: fns that accepts any obj in the passengerCarrier interface
    //call loadPasseneger and use toString on it
    // Restrictions: None
    public static void AddPassenger(IPassengerCarrier obj)
    { 
        //call LoadPass using ref to the interface
        obj.LoadPassenger();
            //if not an IPassengerCarrier object, then error b/c of the function LoadPasseneger.
            //use ToString()
        obj.ToString();
    }
    
    }//program

}//Traffic
