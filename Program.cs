using System;
using Vehicles;

namespace DefiningClasses_6
{
    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Testing polymorphism with the Vehicles Library 
     */
    class Program
    {
        /* Method: Main
         * Purpose: create two objects one containing IPassengerCarrier and one that dosnt and output the result of AddPassenger()
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create an object with IPassengerCarrier
            IPassengerCarrier iPC = new Compact();
            AddPassenger(iPC);
            iPC = new SUV();
            AddPassenger(iPC);
            iPC = new Pickup();
            AddPassenger(iPC);
            iPC = new PassengerTrain();
            AddPassenger(iPC);
            // create an object without IPassengerCarrier
            _424DoubleBogey _424 = new _424DoubleBogey();
            // call 
            //AddPassenger(_424); -> error 424DoubleBogey dosnt inherit IPassengerCarrier
        }
        /* Method: AddPassenger
         * Purpose: Load a passenger from any IPassengerCarrier and output the to string
         * Restrictions: None
         */
        public static void AddPassenger(IPassengerCarrier iPC)
        {
            // load the passenger
            iPC.LoadPassanger();
            // output the object ToString of the object
            Console.WriteLine(iPC.ToString());
        }
    }
}
