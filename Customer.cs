using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellingTicketOOP
{
    public class Customer
    {
        double VIP_REDUCE = 0.01;
        double payment;
        public bool VIP{ get ; set ; }
        public Ticket MyTicket { get; set; }
        // private string ticket;
        public Customer()
        {
            MyTicket = new Ticket();    
        }
        public int GetMovieChoice()
        {
            Console.WriteLine("What movie you want to choose: ");
            int choice = int.Parse(Console.ReadLine());
            return choice -1;
            // if (input == null)
            // {
            //     Console.WriteLine("Please enter a movie name: ");
            //     return;
            // }
            // else
            // {
            //     this.ticket = input;
            // }
        }
        public int GetNumTicket()
        {
            Console.WriteLine("How many tickets do you want: ");
            int nTicket = int.Parse(Console.ReadLine());
            Console.WriteLine("Your tickets: "+ nTicket);
            Console.WriteLine("---------------------");
            return nTicket;
        }
        public string GetSeats(int nTicket)
        {
            string seats = MyTicket.Seats;
            Console.WriteLine("Choose your seats:");
            for (int i = 0; i < nTicket; i++)
            {
                Console.Write("\t- ");
                seats += Console.ReadLine() + " ";
            }
            // Console.WriteLine("How many seats do you want");
            // int input = int.Parse(Console.ReadLine());
            // Console.WriteLine("Your seats:" + input);
            return seats;
            Console.WriteLine("---------------------");
        }
        public void IsVIP()
        {
            // Console.WriteLine("Is VIP? ");
            // bool VIP = true;
            Console.WriteLine("Are you VIP y/n?");
            string answer = Console.ReadLine();
            // VIP = (answer == "y");
            if (answer == "n")
            {
                Console.WriteLine("You are not VIP");
            }
            else if (answer == "y")
            {
                VIP = true;
                payment -= payment * VIP_REDUCE;
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
            Console.WriteLine("---------------------");
        }
    }
}