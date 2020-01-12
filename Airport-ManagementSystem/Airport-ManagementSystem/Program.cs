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
            var boarding = new BoardingPass();


            while(true)
            {
                Console.WriteLine("If you finished adding passagers Write exit");

                Console.WriteLine("Write Passanger name\n");
                string passengerName = Console.ReadLine();

                if (passengerName == "Exit")
                {
                    break;
                }

                Console.WriteLine("Write Departure Aeroport\n");
                string departureAeroport = Console.ReadLine();

                Console.WriteLine("Write Arrival Aeroport\n");
                string arrivalAeroport = Console.ReadLine();

                

                

                var ticket = new Ticket(passengerName, departureAeroport, arrivalAeroport);

                boarding.storingTickets(ticket);

            }

            boarding.Printing();

        }
    }
}
