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
            Vehicle vehicle = null;
            addPassenger(vehicle);
        }
    }//program

    // Method: addPassenger
    // Purpose: fns that accepts any obj in the passengerCarrier interface
    //call loadPasseneger and use toString on it
    // Restrictions: None
    public void addPassenger(object vehicle)
    {
        //call LoadPass using ref to the interface

        //use ToString() 
        vehicle.ToString();
    }


}//Traffic
