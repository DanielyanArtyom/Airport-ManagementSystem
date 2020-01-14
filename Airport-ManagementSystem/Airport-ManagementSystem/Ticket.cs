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


        public Random gen = new Random();
        public  double  BonusPoint()
        {
            double bonusPoint = gen.Next(0, 5000);

            return bonusPoint;
        }

    }
}
