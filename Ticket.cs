using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellingTicketOOP
{
    public class Ticket
    {
        private string movie;
        private string seats;
        private int number;

        public string Movie
        {
            get { return movie; }
            set
            {
                if (value == "") movie = "Supermen";
                movie = value;
            }
        }
        public string Seats
        {
            get { return seats; }
            set
            {
                if (value == "") seats = "ABC01";
                seats = value;
            }
        }
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0) number = 1;
                else if (value > 100) number = 50;
                number = value;
            }
        }
        public Ticket()
        {
            Movie = "";
            Seats = "";
            Number = 0;
        }
        public Ticket(string movie, string seats, int number)
        {
            this.Movie = movie;
            this.Seats = seats;
            this.Number = number;
        }
        
    }
}