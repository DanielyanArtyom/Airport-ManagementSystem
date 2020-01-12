using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_ManagementSystem
{
    class BoardingPass 
    {
       
        List<Ticket> storing = new List<Ticket>(); // for storing and counting ;
        
        SeatArea seatPlace = SeatArea.economy; // its by default;

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
               if(max < storing[i].BonusPoint())
                {
                    max = storing[i].BonusPoint();
                }
            }

            for (int i = 0; i < storing.Count(); i++)
            {
                avg += storing[i].BonusPoint();
                
            }

            threshold = avg + ((max - avg) * 0.25 );

            return threshold;
        }


        public SeatArea seatingPlace()
        {
            for (int i = 0; i < storing.Count(); ++i)
            {
                if(Threshold() < storing[i].BonusPoint())
                {
                    return SeatArea.business;
                }
            }

            return SeatArea.economy;
        }

        public void Printing()
        {
            for (int i = 0; i < storing.Count(); i++)
            {
                Console.WriteLine($"Passanger Name is:{storing[i].passengerName}\n ");
                Console.WriteLine($"From:{storing[i].departureAeroport} \n");
                Console.WriteLine($"To:{storing[i].arrivalAeroport}\n ");
                Console.WriteLine($"Day: {storing[i].RandomDay()}");
               

            }

        }
        

    }
}
