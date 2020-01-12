using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_ManagementSystem
{
    class Ticket
    {
        public string passengerName { get; set; }
        public string departureAeroport { get; set; }
        public string arrivalAeroport { get; set; }

        // our construcor

        public Ticket(string passengerName, string departureAeroport, string arrivalAeroport)
        {
            this.passengerName = passengerName;
            this.departureAeroport = departureAeroport;
            this.arrivalAeroport = arrivalAeroport;
        }


        // RanomGenerations


        private Random gen = new Random();

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

      public  DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        
      public  double  BonusPoint()
        {
            double bonusPoint = gen.Next(0, 5000);

            return bonusPoint;
        }
       
     






    }
}
