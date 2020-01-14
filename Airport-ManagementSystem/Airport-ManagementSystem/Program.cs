using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_ManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Departure Aeroport");
            string departureAeroport = Console.ReadLine();

            Console.WriteLine("Write Arrival Aeroport");
            string arrivalAeroport = Console.ReadLine();

            Console.WriteLine("Write Passanger Name and Surname");
            string passengerName = Console.ReadLine();


            var boarding = new BoardingPass(passengerName, departureAeroport, arrivalAeroport);

            var ticket = new BoardingPass(passengerName, departureAeroport, arrivalAeroport);

            boarding.storingTickets(ticket);

            for (int i = 0; ; ++i)
            {
                Console.WriteLine("If you finished adding passangers pls write Exit");


                Console.WriteLine("Write Another Passanger Name and Surname");
                passengerName = Console.ReadLine();

                if(passengerName == "Exit")
                {
                    break;
                }


                var ticket_1 = new BoardingPass(passengerName, departureAeroport, arrivalAeroport);
                boarding.storingTickets(ticket_1);

            }

            boarding.printing();




        }
    }
}
