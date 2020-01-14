using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_ManagementSystem
{
    class BoardingPass : Ticket
    {

        List<Ticket> storing = new List<Ticket>(); // for storing and counting ;

        public BoardingPass(string passengerName, string departureAeroport, string arrivalAeroport) : base(passengerName, departureAeroport, arrivalAeroport)
        {
        }


        public int countTickets()
        {
            return storing.Count();
        }

        public void storingTickets(Ticket ticket)
        {
            storing.Add(ticket);

        }

        public double Threshold()
        {
            double avg = 0;
            double max = 0;
            double threshold = 0.0;

            for (int i = 0; i < storing.Count(); ++i)
            {
                if (max < storing[i].BonusPoint())
                {
                    max = storing[i].BonusPoint();
                }
            }

            for (int i = 0; i < storing.Count(); i++)
            {
                avg += storing[i].BonusPoint();

            }

            threshold = avg + ((max - avg) * 0.25);

            return threshold;
        }

        private DateTime DepartureRandomDay = new DateTime();
        


        public int GateNumber()

        {
            int gateNumber = gen.Next(1, 15);
            return gateNumber;
        }
        string FlightNumber()
        {
            string generator = "abcdefghijklmnopqrstuvwxyz123456789"; // from where i want to put symbol

            int length = 5; // number lenght
            string random = "";
            for (int i = 0; i < length; ++i)
            {
                int taker = gen.Next(35); // generat random number from 0 to 35;
                random += generator.ElementAt(taker); // giving random element from generator ;
            }

            return random;
        }


        public SeatArea seatingPlace()
        {
            for (int i = 0; i < storing.Count(); ++i)
            {
                if (Threshold() < storing[i].BonusPoint())
                {
                    return SeatArea.business;
                }
            }

            return SeatArea.economy;
        }

        public void printing()
        {
            foreach (var passanger in storing)
            {
                Console.WriteLine();
                Console.WriteLine($"Passanger Name is: {passanger.passengerName}");
                Console.WriteLine($"Departure Aeroport is:{passanger.departureAeroport}");
                Console.WriteLine($"rrival Aeroport is: {passanger.arrivalAeroport}");
                Console.WriteLine($"Departure Date: {DepartureRandomDay.Hour} : {DepartureRandomDay.Minute}");
                Console.WriteLine($"Arrival Date :{DepartureRandomDay.AddHours(gen.Next(1, 24))} : {DepartureRandomDay.AddMinutes(gen.Next(1, 60))}");
                Console.WriteLine($"SeatPlace :{seatingPlace()}");
                Console.WriteLine($"Gate : {FlightNumber()}");
                Console.WriteLine($"Gate : {GateNumber()}");
                Console.WriteLine($"You have : {passanger.BonusPoint()} bonus points");
                
            }


        }

    }
}
